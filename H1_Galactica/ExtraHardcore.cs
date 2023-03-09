using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Galactica
{
    public class ExtraHardcore
    {

        public CoordSet GetHardcoreValue(CoordSet startingCoords, double RevolutionPeriodInDays, double timeSpanInYears)
        {
            CoordSet endingCoords = new CoordSet();

            double angle = 2 * Math.PI * (timeSpanInYears % (RevolutionPeriodInDays / 365.0)) / (RevolutionPeriodInDays / 365.0);
            double x = startingCoords.xCoord * Math.Cos(angle) - startingCoords.yCoord * Math.Sin(angle);
            double y = startingCoords.xCoord * Math.Sin(angle) + startingCoords.yCoord * Math.Cos(angle);

            endingCoords.xCoord = x;
            endingCoords.yCoord = y;

            return endingCoords;
        }


        public class CoordSet
        {
            public double xCoord { get; set; }
            public double yCoord { get; set; }

        }
    }
}