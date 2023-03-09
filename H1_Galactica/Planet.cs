using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public class Planet : SpaceObject
    {
        public PlanetType Type { get; set; }
        public double DiameterInMeters { get; set; }
        public double RotationPeriodInHours { get; set; }
        public double RevolutionPeriodDays { get; set; }
        public Star OrbitingStar { get; set; }
        public List<Moon> Moons { get; set; }

        public Planet()
        {
            Type = PlanetType.Terrestrial;
            DiameterInMeters = 0;
            RotationPeriodInHours = 0;
            RevolutionPeriodDays = 0;
            OrbitingStar = null;
            Moons = new List<Moon>();
        }

        public virtual double Distance()
        {
            double dx = Position._xCoord - OrbitingStar.Position._xCoord;
            double dy = Position._yCoord - OrbitingStar.Position._yCoord;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public enum PlanetType
        {
            Terrestrial,
            Giant,
            Dwarf,
            GasGiant,
        }

    }
}
