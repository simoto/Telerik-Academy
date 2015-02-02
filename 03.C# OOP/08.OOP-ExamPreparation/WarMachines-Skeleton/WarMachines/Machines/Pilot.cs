namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private ICollection<IMachine> machines;
        private string name;

        public Pilot(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Pilot can't hold null information!");
            }
            this.name = name;
            this.machines = new List<IMachine>();
        }
        public string Name
        {
            get { return this.name; }
        }

        public void AddMachine(IMachine machine)
        {            
            this.machines.Add(machine);
            this.machines.OrderBy(x => x.HealthPoints).ThenBy(y => y.Name);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            string numberOfMachines = "";
            string oneOrMoreMachine = "machines";

            if (this.machines.Count == 0)
            {
                numberOfMachines = "no";
            }
            else if (this.machines.Count == 1)
            {
                numberOfMachines = "1";
                oneOrMoreMachine = "machine";
            }
            else
            {
                numberOfMachines = this.machines.Count.ToString();
            }
            report.AppendLine(this.name + " - " + numberOfMachines + " " + oneOrMoreMachine);
            if (this.machines.Count != 0)
            {
                foreach (var machine in this.machines.OrderBy(x => x.HealthPoints).ThenBy(y => y.Name))
                {
                    report.AppendLine(machine.ToString());
                    //TODO: да си довършим работата тука;
                }
            }
            
            return report.ToString().Trim();
        }
    }
}
