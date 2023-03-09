using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public class Data
    {
        public Star Sun;
        public Planet Planet;

        public void OutputData()
        {
            int padding = 13;
            int indent1 = 5;
            int indent2 = 13;

            Console.CursorVisible = false;

            foreach (Planet planet in Sun.Planets)
            {
                AddIndentation($"Name:   {planet.Name.PadRight(padding)} Type: {planet.Type.ToString().PadRight(padding)} Distance: {planet.Distance().ToString("0.00")} ", indent1, true);

                if (planet.Moons != null && planet.Moons.Count > 0)
                {
                    AddIndentation("Moons:", indent1);
                    foreach (Moon moon in planet.Moons)
                    {
                        AddIndentation($"{moon.Name.PadRight(padding)} Distance: {moon.Distance().ToString("0.00")}", indent2, true);

                    }
                }
                Console.WriteLine();
                InsertSeperator();
            }
        }

        public void InsertSeperator()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public void AddIndentation(string output, int indentation, bool newLine = false)
        {
            Console.CursorLeft = indentation;

            Console.Write(output);
            if (newLine)
            {
                Console.WriteLine();
            }

        }

        public void AddData()
        {
            Sun = new Star()
            {
                Id = 0,
                Name = "Sun",
                Type = Star.StarType.YellowDwarf,
                TemperatureKelvin = 5800,
            };

            #region planets

            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                Type = Planet.PlanetType.Terrestrial,
                DiameterInMeters = 5000,
                RotationPeriodInHours = 1400,
                RevolutionPeriodDays = 90,
                Position = new SpaceObject.PositionMethods { _xCoord = 5, _yCoord = 5 },
                OrbitingStar = Sun,
            };

            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                Type = Planet.PlanetType.Terrestrial,
                DiameterInMeters = 12000,
                RotationPeriodInHours = 5832,
                RevolutionPeriodDays = 225,
                Position = new SpaceObject.PositionMethods { _xCoord = 10, _yCoord = 8 },
                OrbitingStar = Sun,
            };

            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                Type = Planet.PlanetType.Terrestrial,
                DiameterInMeters = 12742,
                RotationPeriodInHours = 24,
                RevolutionPeriodDays = 365,
                Position = new SpaceObject.PositionMethods { _xCoord = 15, _yCoord = 10 },
                OrbitingStar = Sun,
            };

            Planet mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                Type = Planet.PlanetType.Terrestrial,
                DiameterInMeters = 6792,
                RotationPeriodInHours = 24.6,
                RevolutionPeriodDays = 687,
                Position = new SpaceObject.PositionMethods { _xCoord = 18, _yCoord = 15 },
                OrbitingStar = Sun,
            };

            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                Type = Planet.PlanetType.GasGiant,
                DiameterInMeters = 142984,
                RotationPeriodInHours = 9.9,
                RevolutionPeriodDays = 4331,
                Position = new SpaceObject.PositionMethods { _xCoord = 25, _yCoord = 20 },
                OrbitingStar = Sun,
            };

            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                Type = Planet.PlanetType.GasGiant,
                DiameterInMeters = 120536,
                RotationPeriodInHours = 10.7,
                RevolutionPeriodDays = 10747,
                Position = new SpaceObject.PositionMethods { _xCoord = 30, _yCoord = 25 },
                OrbitingStar = Sun,
            };

            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                Type = Planet.PlanetType.Giant,
                DiameterInMeters = 51118,
                RotationPeriodInHours = 17.2,
                RevolutionPeriodDays = 30589,
                Position = new SpaceObject.PositionMethods { _xCoord = 35, _yCoord = 30 },
                OrbitingStar = Sun,
            };

            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                Type = Planet.PlanetType.Giant,
                DiameterInMeters = 49528,
                RotationPeriodInHours = 16.1,
                RevolutionPeriodDays = 59800,
                Position = new SpaceObject.PositionMethods { _xCoord = 40, _yCoord = 35 },
                OrbitingStar = Sun,
            };
            #endregion

            #region moons

            Moon luna = new Moon()
            {
                Id = 9,
                Name = "Luna",
                DiameterInMeters = 3475,
                RotationPeriodInHours = 708.7,
                RevolutionPeriodDays = 27.32,
                Position = new SpaceObject.PositionMethods { _xCoord = -5, _yCoord = -7 },
                OrbitingPlanet = earth
            };

            Moon titan = new Moon()
            {
                Id = 10,
                Name = "Titan",
                DiameterInMeters = 5150,
                RotationPeriodInHours = 382.68,
                RevolutionPeriodDays = 15.95,
                Position = new SpaceObject.PositionMethods { _xCoord = 2, _yCoord = -1 },
                OrbitingPlanet = saturn
            };

            Moon phobos = new Moon()
            {
                Id = 11,
                Name = "Phobos",
                DiameterInMeters = 22.2,
                RotationPeriodInHours = 7.7,
                RevolutionPeriodDays = 0.32,
                Position = new SpaceObject.PositionMethods { _xCoord = -1, _yCoord = 3 },
                OrbitingPlanet = mars
            };

            Moon europe = new Moon()
            {
                Id = 12,
                Name = "Europe",
                DiameterInMeters = 3121,
                RotationPeriodInHours = 85,
                RevolutionPeriodDays = 3.55,
                Position = new SpaceObject.PositionMethods { _xCoord = 0, _yCoord = 5 },
                OrbitingPlanet = jupiter
            };

            Moon deimos = new Moon()
            {
                Id = 13,
                Name = "Deimos",
                DiameterInMeters = 12.4,
                RotationPeriodInHours = 30.3,
                RevolutionPeriodDays = 1.26,
                Position = new SpaceObject.PositionMethods { _xCoord = 2, _yCoord = 2 },
                OrbitingPlanet = mars
            };

            Moon ganymedes = new Moon()
            {
                Id = 14,
                Name = "Ganymedes",
                DiameterInMeters = 5262.4,
                RotationPeriodInHours = 171.7,
                RevolutionPeriodDays = 7.16,
                Position = new SpaceObject.PositionMethods { _xCoord = -5, _yCoord = 7 },
                OrbitingPlanet = jupiter
            };

            Moon io = new Moon()
            {
                Id = 15,
                Name = "Io",
                DiameterInMeters = 3642,
                RotationPeriodInHours = 42.46,
                RevolutionPeriodDays = 1.77,
                Position = new SpaceObject.PositionMethods { _xCoord = 11, _yCoord = 7 },
                OrbitingPlanet = jupiter
            };

            Moon mimas = new Moon()
            {
                Id = 16,
                Name = "Mimas",
                DiameterInMeters = 396.4,
                RotationPeriodInHours = 22.6,
                RevolutionPeriodDays = 0.94,
                Position = new SpaceObject.PositionMethods { _xCoord = -11, _yCoord = 3 },
                OrbitingPlanet = saturn
            };

            #endregion

            earth.Moons = new List<Moon> { luna };
            saturn.Moons = new List<Moon> { titan, mimas };
            mars.Moons = new List<Moon> { phobos, deimos };
            jupiter.Moons = new List<Moon> { europe, ganymedes, io };

            Sun.Planets = new List<Planet> { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune };
        }
    }
}
