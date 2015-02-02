namespace MobileDeviceInformationCenter
{
    using System;

    class GSMTest
    {
        private static GSM[] Liist = new GSM[3];

        public static void Test()
        {
            Liist[0] = new GSM("Nokia 5800", "Nokia", 150, "Neznam", new Battery("Nokia", 450, 20, BatteryType.NiCd), new Display(2.8m, 8000000));

            Liist[1] = new GSM("LG 3D", "LG", 670, "Kitaec", new Battery("Samsung", 350, 25, BatteryType.NiMH),new Display(3.2m, 12000000));

            Liist[2] = GSM.Iphone4S;
        }

        public static void Print()
        {
            Console.WriteLine(Liist[0]);
            Console.WriteLine();
            Console.WriteLine(Liist[1]);
            Console.WriteLine();
            Console.WriteLine(Liist[2]);
        }
    }
}
