namespace MobileDeviceInformationCenter
{
    public class Battery
    {
        private string batteryModel;
        private decimal hoursIdle;
        private decimal hoursTalk;
        private BatteryType type;

        public Battery()
        {
        }

        public Battery(string model, decimal hourIdle, decimal hourTalk, BatteryType types)
        {
            this.batteryModel = model;
            this.hoursIdle = hourIdle;
            this.hoursTalk = hourTalk;
        }

        public BatteryType GetBatteryType
        {
            get { return this.type; }      
        }

        public string GetBatteryModel
        {
            get { return this.batteryModel; }
        }

        public decimal GetHourIdle
        {
            get { return this.hoursIdle; }
        }

        public decimal GetHourTalk
        {
            get { return this.hoursTalk; }
        }
    }
}