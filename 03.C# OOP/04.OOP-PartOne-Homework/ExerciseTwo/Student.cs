using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Student : Human
    {
        private int grade;

        public Student()
        {
            
        }

        public Student(int grade)
        {
            this.grade = grade;
            this.FirstName = string.Format("Student with grade {0}", grade);
        }

        public int GetGrade
        {
            get { return this.grade; }
        }
    }
}
