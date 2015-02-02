namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;
    
    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(attackPoints.ToString())
                || string.IsNullOrWhiteSpace(defensePoints.ToString()) || string.IsNullOrWhiteSpace(stealthMode.ToString()))
            {
                throw new ArgumentException("Fighter can't hold null information!");
            }
            this.stealthMode = stealthMode;
            this.HealthPoints = 200;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            if (this.stealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine(base.ToString());

            if (this.StealthMode)
            {
                report.AppendLine(" *Stealth: ON");
            }
            else
            {
                report.AppendLine(" *Stealth: OFF");
            }

            return report.ToString().TrimEnd();
        }
    }
}