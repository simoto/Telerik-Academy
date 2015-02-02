namespace MobileDeviceInformationCenter
{
    using System;

    class MobilePhoneDevice
    {
        static void Main()
        {
            GSMTest.Test();
            GSMTest.Print();

            Console.WriteLine();

            GSMCallHistoryTest.AddTestCall();
            GSMCallHistoryTest.ShowPriceDuration();
            GSM testt = GSM.Iphone4S;

            testt.AddCall("10/11/12", "13:12", "08989898989", 78);
            testt.AddCall("10/11/12", "13:20", "08989898989", 68);

            testt.AssumedCallPrice();           
        }
    }
}