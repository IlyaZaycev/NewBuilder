using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class WallBuilder
    {
        private Wall wall = new Wall();

        public Wall Wall
        {
            get { return wall; }
            set { wall = value; }
        }
        public abstract Wall CreateWall();
        public abstract void SetHP(uint hp);
        public abstract void SetVertIntWall(char a);
        public abstract void SetHorizIntWall(char b);
        public abstract void SetVertOutWall(char a);
        public abstract void SetHorizOutWall(char b);
    }
}
