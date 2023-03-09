using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public abstract class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PositionMethods Position { get; set; } = new PositionMethods();

        public class PositionMethods
        {
            public double _xCoord { get; set; }
            public double _yCoord { get; set; }

            public override string ToString()
            {
                return $"({_xCoord},{_yCoord})";
            }

            public void SetPosition(int xCoord, int yCoord)
            {
                _xCoord = xCoord;
                _yCoord = yCoord;
            }
        }
    }
}