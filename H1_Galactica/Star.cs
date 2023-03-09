using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public class Star : SpaceObject
    {
        public StarType Type { get; set; }
        public double TemperatureKelvin { get; set; }
        public List<Planet> Planets { get; set; }

        public Star()
        {
            Position.SetPosition(0, 0);
            Planets = new List<Planet>();
        }

        public enum StarType
        {
            YellowDwarf,
            White,
            BlueNeutron,
            RedGiant
        }
    }
}
