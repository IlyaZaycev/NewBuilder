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

        public override void SetHorizIntWall(char b)
        {
            Wall.HorWall = b;
        }

        public override void SetHorizOutWall(char b)
        {
        }

        public override void SetHP(uint hp)
        {
        }

        public override void SetVertIntWall(char a)
        {
            Wall.VertWall = a;
        }

        public override void SetVertOutWall(char a)
        {
        }
    }
}
