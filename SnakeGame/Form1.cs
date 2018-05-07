using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Random randomFood = new Random();

        Graphics paper;
        Snake snake = new Snake();// adaugam in form sarpele nostru
        GameLevels testWall;
        Food food;

        //mai jos directile sarpelui
        bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;

        int score = 0; 
        public Form1()
        {
            InitializeComponent();
            food = new Food(randomFood);//ca mancarea sa fie vizibila pe ecran o initializam aici
            testWall = new GameLevels();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)// in enventul asta desenam mancarea si sarpele
        {
            paper = e.Graphics;
            food.DrawFood(paper);
            snake.DrawSnake(paper);
            testWall.DrawWall(paper);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)// in event-ul asta folosim controalele definite mai sus
        {
            if(e.KeyData == Keys.Space)// cand se apasa space incepe jocul 
            {
                timer1.Enabled = true;
                SpaceBarLebel.Text = "";
                down = false;
                up = false;
                left = false;
                right = true;
            }
            if (e.KeyData == Keys.Down && up == false)//apasam pe segeata in jos
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Up && down == false)//apasam pe segeata in sus
            {
                down = false;
                up = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)//apasam pe segeata in dreapta
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }
            if (e.KeyData == Keys.Left && right == false)//apasam pe segeata in stanga
            {
                down = false;
                up = false;
                left = true;
                right = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//evenimentul ce va gestiona viteza, timpul de miscare al sarpelui
        {
            SnakeScoreLabel.Text = Convert.ToString(score);// facem conversia scorului din int in string 
            if (down)
            {
                snake.MoveDown();
            }
            if (up)
            {
                snake.MoveUp();
            }
            if (left)
            {
                snake.MoveLeft();
            }
            if (right)
            {
                snake.MoveRight();
            }
            //mai jos detectarea inpactului, sa vedem ce se intampla atunci cand sarpele ajunge la mancare 
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))// intoarce o valoare bool, verifica daca se interesecteaza sarpele cu mancarea   
                {
                    score += 10; // adaugam la scor 10 puncte 
                    snake.GrowSnake();
                    food.FoodLocation(randomFood);// atunci cand sarpele se intersecteaza cu mancarea, se apeleaza metoda FoodLocation si se creaza din nou un obiect de tip food random
                }
            }
            Colision();
            WallColision();
            this.Invalidate();
        }
        public void Colision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))// daca se loveste de el..
                {
                    Restart();
                }
            }
            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X >290)// daca se loveste de perete.
            {
                Restart();
            }
            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 290)// daca se loveste de perete.
            {
                Restart();
            }
        }
        public void WallColision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if(snake.SnakeRec[0].IntersectsWith(testWall.WallRec))
                {
                    Restart();
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        public void Restart()// metoda de restart atunci cand sarpele se loveste de perete sau de el 
        {
            timer1.Enabled = false;
            MessageBox.Show("Game over! You scored: " + score);
            SnakeScoreLabel.Text = "0";
            score = 0;
            SpaceBarLebel.Text = "Press space bar to begin.";
            snake = new Snake();
        }
    }
}
