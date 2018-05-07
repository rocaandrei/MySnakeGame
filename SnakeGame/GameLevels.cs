using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameLevels
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle WallRec;

        public GameLevels()
        {
            //un perete fix
            x = 135;
            y = 45;
            width = 10;
            height = 60;
            brush = new SolidBrush(Color.Black);

            WallRec = new Rectangle(x, y, width, height);
        }
        public void WallLocation()
        {
            x = 45;
            y = 0;
        }
        public void DrawWall(Graphics paper)
        {
            WallRec.X = x;
            WallRec.Y = y;
            paper.FillRectangle(brush, WallRec);
        }

    }
}
