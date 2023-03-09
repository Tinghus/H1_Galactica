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

            // We need to take into account that we can have more than 1 revolution in our timespan. So we use modulo to get the remainder
            // We then use the remainder to calculate our radian, 1 radian = 57 degrees
            double angle = 2 * Math.PI * (timeSpanInYears % (RevolutionPeriodInDays / 365.0)) / (RevolutionPeriodInDays / 365.0);

            // We use our angle with our cosine and sine to calculate the position of x and y
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