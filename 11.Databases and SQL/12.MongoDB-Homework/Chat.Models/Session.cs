namespace Chat.Models
{
    using System;

    public class Session
    {
        public Session(string name)
        {
            this.Name = name;
            this.LoggedOn = DateTime.Now;
        }

        public string Name { get; set; }

        public DateTime LoggedOn { get; set; }
    }
}
