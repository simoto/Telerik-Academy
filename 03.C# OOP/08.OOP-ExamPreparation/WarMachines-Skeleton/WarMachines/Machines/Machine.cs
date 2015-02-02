namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {  
        protected double attackPoints;
        protected double defensePoints;
        protected IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.targets = new List<string>();
        }
        public string Name { get; set; }

        public IPilot Pilot { get; set; }

        public double HealthPoints { get; set; }

        public double AttackPoints
        {
            get { return this.attackPoints; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();


            report.AppendLine("- " + this.Name);
            report.AppendLine(" *Type: " + this.GetType().Name);
            report.AppendLine(" *Health: " + this.HealthPoints);
            report.AppendLine(" *Attack: " + this.AttackPoints);
            report.AppendLine(" *Defense: " + this.DefensePoints);

            if (this.Targets.Count == 0)
            {
                report.AppendLine(" *Targets: None");
            }
            else
            {
                report.AppendLine(string.Format(" *Targets: {0}", string.Join(", ", this.Targets).Trim(',')));
            }

            return report.ToString().TrimEnd();
        }
    }
}