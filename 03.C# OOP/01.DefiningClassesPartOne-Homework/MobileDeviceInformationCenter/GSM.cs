namespace MobileDeviceInformationCenter
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string gsmModel;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iphone4S = new GSM("Iphone 4S", "Apple", 450.00m, "Apple",
            new Battery("Apple", 350, 15, BatteryType.LiIon), new Display(3.5m, 16000000));
        private List<Call> callHistory = new List<Call>();

        public GSM()
        {

        }

        public GSM(string gsmModel, string manufacturer)
        {
            this.gsmModel = gsmModel;
            this.manufacturer = manufacturer;
        }

        public GSM(string gsmModel, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.gsmModel = gsmModel;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public decimal SetPrice
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string SetOwner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public void SetBattery(string model, decimal hourIdle, decimal hourTalk, BatteryType type)
        {
            this.battery = new Battery(model, hourIdle, hourTalk, type);
        }

        public void SetDisplay(decimal displaySize, decimal numOfColor)
        {
            this.display = new Display(displaySize, numOfColor);
        }

        public override string ToString()
        {
            return String.Format("Model: {0} \nManufacturer: {1} \nPrice: {2} \nOwner: {3} \nBatteryModel: {4} \nHourIdle: {5} \nHourTalk: {6} \nBatteryType: {7} \nDisplaySize: {8} \nColours: {9}"
                   , this.gsmModel, this.manufacturer, this.price, this.owner, this.battery.GetBatteryModel, this.battery.GetHourIdle, this.battery.GetHourTalk, this.battery.GetBatteryType, this.display.GetDisplaySize, this.display.GetColor);

        }

        public void AddCall(string date, string time, string number, int duration)
        {
            this.callHistory.Add(new Call(date, time, number, duration));
        }

        public void RemoveCall(int index)
        {
            this.callHistory.Remove(callHistory[index]);
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public decimal AssumedCallPrice()
        {
            decimal pricePerMinute = 0.37m;
            decimal duration = 0;

            foreach (Call item in this.callHistory)
            {
                duration += item.GetDuration;
            }

            duration /= 60m;

            return duration * pricePerMinute;
        }

        public static GSM Iphone4S
        {
            get { return iphone4S; }
        }

        public void GetCallListItems()
        {

            foreach (var item in this.callHistory)
            {
                Console.WriteLine();
                Console.WriteLine("Date: {0}\nTime: {1}\nNumber: {2}\nDuration: {3}", item.GetDate, item.GetTime, item.GetPhoneNumber, item.GetDuration);
            }
        }
    }
}
