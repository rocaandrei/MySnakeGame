using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Food
    {
        private int x, y, width, height;//acelasi principiu ca la sarpe, trebuie sa ii definim dimensiunile 
        private SolidBrush brush;
        public Rectangle foodRec;

        public Food(Random randomFood)// aici construim mancarea random, sa ne apare pe ecran
        {
            x = randomFood.Next(0, 29) * 10; //inmultim ori 10, ca sa facem mancarea de aceeasi dimensiune ca si sarpele 
            y = randomFood.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Red);
            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }
        public void FoodLocation(Random randomFood)// stabilim locatia random pt mancare 
        {
            x = randomFood.Next(0, 29) * 10;
            y = randomFood.Next(0, 29) * 10;
        }
        public void DrawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);
        }
    }
}
