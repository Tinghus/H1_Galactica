namespace H1_Galactica
{
    internal class Program
    {
        static Data Data = new Data();
        static ExtraHardcore ExtraHardcore = new ExtraHardcore();

        static void Main(string[] args)
        {
            Data.AddData();
            Data.OutputData();

            Console.ReadKey();
            Console.Clear();

            // Hardcore
            ExtraHardcore.CoordSet startingCoords = new ExtraHardcore.CoordSet();
            startingCoords.xCoord = 35;
            startingCoords.yCoord = 52;
            double timeSpanInYears = 2;
            double RevolutionPeriodInDays = 365 * 12;

            ExtraHardcore.CoordSet result = ExtraHardcore.GetHardcoreValue(startingCoords, RevolutionPeriodInDays, timeSpanInYears);

            Console.WriteLine("Hardcore:");
            Console.WriteLine($"Starting Coords : x: {startingCoords.xCoord} y: {startingCoords.yCoord}");
            Console.WriteLine($"Ending Coords : x: {result.xCoord.ToString("0.00")} y: {result.yCoord.ToString("0.00")}");

            Console.ReadKey();
        }
    }
}