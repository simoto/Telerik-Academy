namespace MobileDeviceInformationCenter
{
    public class Display
    {
        private decimal displaySize;
        private decimal numberOfColor;

        public Display()
        {

        }

        public Display(decimal displaySize, decimal numberOfColor)
        {
            this.displaySize = displaySize;
            this.numberOfColor = numberOfColor;
        }

        public decimal GetDisplaySize
        {
            get { return this.displaySize; }
        }

        public decimal GetColor
        {
            get { return this.numberOfColor; }
        }
    }
}
