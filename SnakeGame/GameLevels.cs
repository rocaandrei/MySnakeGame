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
        private SolidBrush brush2;
        public Rectangle WallRec;
        public Rectangle WallRec2;

        public GameLevels()
        {
            //un perete fix
            x = 30;
            y = 170;
            width = 10;
            height = 60;
           brush = new SolidBrush(Color.Black);
            brush2 = new SolidBrush(Color.Black);//TO DO: sa vad de ce nu pot sa colorez si asta, si sa verific si WallRec2
           WallRec = new Rectangle(x, y, width, height);
            WallRec2 = new Rectangle(280, 10, width, height);
        }
        public void WallLocation()
        {
            x = 30;
            y = 15;
        }
        public void DrawWall(Graphics paper)
        {
            WallRec.X = x;
            WallRec.Y = y;
            paper.FillRectangle(brush, WallRec);
            paper.FillRectangle(brush2, WallRec2);
        }

    }
}
