namespace MobileDeviceInformationCenter
{
    class Call
    {
        private string date;
        private string time;
        private string dialedPhone;
        private decimal duration;

        public Call()
        {
        }

        public Call(string date, string time, string dialedPhone, decimal duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        public string GetDate
        {
            get { return this.date; }
        }

        public decimal GetDuration
        {
            get { return this.duration; }
        }

        public string GetTime
        {
            get { return this.time; }
        }

        public string GetPhoneNumber
        {
            get { return this.dialedPhone; }
        }       
    }
}