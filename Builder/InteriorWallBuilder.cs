using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InteriorWallBuilder : WallBuilder
    {
        public InteriorWallBuilder()
        {
            Wall = new InteriorWall();
        }
        public override Wall CreateWall()
        {
            return Wall;
        }

        public override void SetVertWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetHorizWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetHP(uint hp)
        {
        }
    }
}
