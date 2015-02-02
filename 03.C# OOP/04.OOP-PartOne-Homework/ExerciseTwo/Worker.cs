using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Worker : Human
    {
        public decimal Salary { get; set; }
        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal perHour = Salary / WorkHoursPerDay;
            return perHour;
        }

        public Worker()
        {
        }

        public Worker(int salary, int hourPerDay)
        {
            this.Salary = salary;
            this.WorkHoursPerDay = hourPerDay;
            this.FirstName = string.Format("Worker with salary {0}", salary);
        }
    }
}
