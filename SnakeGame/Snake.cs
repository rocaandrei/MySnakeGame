using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //pentru ca vom desena chestii

namespace SnakeGame
{
    public class Snake
    {
        private Rectangle[] snakeRec;
        public SolidBrush brush; //vom face sarpele vizibil asa 
        private int x, y, width, height;

        public Rectangle[] SnakeRec // asa facem o propietate read only, avem mai sus propietatea de tip private si creem un obiect aici jos
        {
            get { return snakeRec; }// ca sa nu avem vaem variabile care sa umbre publice 
        }
        public Snake()
        {
            snakeRec = new Rectangle[3];//dimensiunea de baza a sarpelui
            brush = new SolidBrush(Color.Aqua);// ce culoare sa aiba sarpele 
            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRec.Length; i++)//aici adaugam dimensiunile sarpelui
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
        public void DrawSnake(Graphics paper)//metoda care va desena sarpele 
        {
            foreach (Rectangle rec in snakeRec)
            {
                paper.FillRectangle(brush, rec);
            }
        }
        public void DrawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)//incepem de la coada sarpelui, urcand spre cap
            {
                snakeRec[i] = snakeRec[i - 1]; // asa se deplaseaza el, isi transfera pozitia in fata 
            }
        }
        //cum se incrementeaza/decrementeaza sarpele pe ecran in diferite pozitii
        public void MoveDown()
        {
            DrawSnake();
            snakeRec[0].Y += 10;
        }
        public void MoveUp()
        {
            DrawSnake();
            snakeRec[0].Y -= 10;
        }
        public void MoveRight()
        {
            DrawSnake();
            snakeRec[0].X += 10;
        }
        public void MoveLeft()
        {
            DrawSnake();
            snakeRec[0].X -= 10;
        }
        public void GrowSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[SnakeRec.Length - 1].X, SnakeRec[snakeRec.Length - 1].Y, width, height));// aici adaugam la sarpe bucati noi la fiecare mancare 
            snakeRec = rec.ToArray();
        }
    }
}
