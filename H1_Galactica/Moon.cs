using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public sealed class Moon : Planet
    {
        public Planet OrbitingPlanet { get; set; }

        public Moon()
        {
            OrbitingPlanet = null;
        }

        public override double Distance()
        {
            double dx = Position._xCoord - OrbitingPlanet.Position._xCoord;
            double dy = Position._yCoord - OrbitingPlanet.Position._yCoord;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}
