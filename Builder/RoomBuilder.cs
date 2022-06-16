using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class RoomBuilder: InteriorWallBuilder
    {
        private const int roomSize = 3;
        private Room room = new Room();
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }
        public void CreateRoom()
        {
            
        }
        public override string ToString()
        {
            return room.ToString();
        }
    }
}
