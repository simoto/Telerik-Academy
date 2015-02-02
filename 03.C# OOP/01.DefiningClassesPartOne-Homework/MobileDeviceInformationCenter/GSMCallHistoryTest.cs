namespace MobileDeviceInformationCenter
{
    using System;

    class GSMCallHistoryTest
    {
        private static GSM testGSM = new GSM("Tester", "Test", 300, "Test", new Battery(), new Display());

        public static void AddTestCall()
        {
            testGSM.AddCall("12/12/12", "13:13", "089898989", 65);
            testGSM.AddCall("13/12/12", "13:14", "089845432", 43);
            testGSM.AddCall("14/12/12", "13:15", "089892343", 62);
            testGSM.AddCall("15/12/12", "13:17", "089892345", 24);
        }

        public static void ShowPriceDuration()
        {
            Console.WriteLine("Price: {0: 0.00}", testGSM.AssumedCallPrice());
        }

        public GSMCallHistoryTest()
        {
        }

        public static void GetCalls()
        {
            testGSM.GetCallListItems();
        }
    }
}