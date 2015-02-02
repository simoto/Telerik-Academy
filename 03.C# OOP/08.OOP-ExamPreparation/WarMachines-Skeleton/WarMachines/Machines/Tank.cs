namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {       
        private bool defenceMode;

        public Tank(string name, double attackPoints, double defensePoints) 
            :base(name, attackPoints, defensePoints)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(attackPoints.ToString())
                || string.IsNullOrWhiteSpace(defensePoints.ToString()))
            {
                throw new ArgumentException("Tank can't hold null information!");
            }

            this.defenceMode = true;
            this.HealthPoints = 100;
            this.defensePoints = defensePoints + 30;
            this.attackPoints = attackPoints - 40;
        }
  
        public bool DefenseMode
        {
            get { return this.defenceMode; }
        }

        public void ToggleDefenseMode()
        {
            if (this.defenceMode)
            {
                this.defensePoints -= 30;
                this.attackPoints += 40;
                this.defenceMode = false;

            }
            else
            {
                
                this.defenceMode = true;
                this.defensePoints += 30;
                this.attackPoints -= 40;
            }
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine(base.ToString());

            if (this.DefenseMode)
            {
                report.AppendLine(" *Defense: ON");
            }
            else
            {
                report.AppendLine(" *Defense: OFF");
            }

            return report.ToString().TrimEnd();
        }
    }
}