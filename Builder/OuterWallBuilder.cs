﻿using System;
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

        public override void SetHorizIntWall(char a)
        {
        }

        public override void SetVertIntWall(char b)
        {
        }

        public override void SetHorizOutWall(char a)
        {
            Wall.HorWall = a;
        }

        public override void SetVertOutWall(char b)
        {
            Wall.VertWall = b;
        }

        public override void SetHP(uint hp)
        {
        }
    }
}
