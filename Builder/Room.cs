using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Room : InteriorWall
    {
        OuterWall outerWall = new OuterWall();
        public OuterWall OuterWall
        {
            get { return outerWall; }
            set { outerWall = value; }
        }
        InteriorWall interiorWall = new InteriorWall();
        public InteriorWall InteriorWall
        {
            get { return interiorWall; }
            set { interiorWall = value; }
        }
        private const int roomSize = 5;
        private char[,] roomArray = new char[roomSize, roomSize]
        {
            {'1','1','1','1','1' },
            {'2','3','1','3','2' },
            {'2','3','1','3','2' },
            {'2','4','4','4','2' },
            {'1','1','1','1','1' }
        };
        public char[,] RoomArray
        {
            get { return roomArray; }
            set
            {
                for (int i = 0; i < roomSize; i++)
                {
                    for (int j = 0; j < roomSize; j++)
                    {
                        if (roomArray[i, j] == '1') { roomArray[i, j] = OuterWall.HorWall; }
                        if (roomArray[i, j] == '2') { roomArray[i, j] = OuterWall.VertWall; }
                        if (roomArray[i, j] == '3') { roomArray[i, j] = InteriorWall.VertWall; }
                        if (roomArray[i, j] == '3') { roomArray[i, j] = InteriorWall.HorWall; }
                    }
                }
            }
        }
    }
}
