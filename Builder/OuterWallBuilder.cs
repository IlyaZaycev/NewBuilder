using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OuterWallBuilder : WallBuilder
    {
        public OuterWallBuilder()
        {
            Wall = new OuterWall();
        }
        public override Wall CreateWall()
        {
            return Wall;
        }

        public override void SetHorizWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetVertWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetHP(uint hp)
        {
        }
    }
}
