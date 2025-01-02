using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz4;

namespace _106_Classwork5_2
{
    class PinBoard
    {
        public int Rows=0;
        public int Cols=0;
        public double XInterval=0;
        public double YInterval=0;
        public Point[,] PinArray = null;

        public void CreatePins()
        {
            PinArray = new Point[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    PinArray[i, j] = new Point();
            }
        }

        public void SetPinPoistions()
        {
            double YPosition;
            double XPosition;

            YPosition = 0;
            for (int i = 0; i < Rows; i++)
            {
                XPosition = 0;
                for (int j = 0; j < Cols; j++)
                {
                    PinArray[i, j].xCoord = XPosition;
                    PinArray[i, j].yCoord = YPosition;
                    XPosition += XInterval;
                }
                YPosition += YInterval;
            }
        }
    }
}
