using System;

namespace Garden
{
    class UnclePesho
    {
        static void Main()
        {
            int tomatoAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageAmount = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansAmount = int.Parse(Console.ReadLine());

           decimal tomato = tomatoAmount * 0.5m;
           decimal cucumber = cucumberAmount * 0.4m;
            decimal potato = potatoAmount * 0.25m;
            decimal carrot = carrotAmount * 0.6m;
            decimal cabbage = cabbageAmount * 0.3m;
            decimal beans = beansAmount * 0.4m;

            int totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            decimal totalCost = tomato + cucumber + potato + carrot + cabbage + beans;
            int beansArea = 250 - totalArea;
            if (totalArea < 250)
            {
                Console.WriteLine("Total costs: {0}",totalCost);
                Console.WriteLine("Beans area: {0}",beansArea);
            }
            else if (totalArea > 250)
            {
                Console.WriteLine("Total costs: {0}",totalCost );
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea == 250)
            {
                Console.WriteLine("Total costs: {0}",totalCost);
                Console.WriteLine("No area for beans"); 
            }
        }
    }
}
