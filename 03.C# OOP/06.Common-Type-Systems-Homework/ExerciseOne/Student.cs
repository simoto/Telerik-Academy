// Define a class Student, which contains data about a student – first,
// middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
// Use an enumeration for the specialties, universities and faculties.
// Override the standard methods, inherited by  
// System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace Exercises
{
    using System;

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int SSN;
        private readonly string address;
        private string mobilePhone;
        private string email;
        private string course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student()
        {
        }

        public Student(string firstName, string midName, string lastName, int SSN, string address,
            string mobilePhone, string mail, string course, Specialty spec, University uni, Faculty fac )
        {
            this.firstName = firstName;
            this.middleName = midName;
            this.lastName = lastName;
            this.SSN = SSN;
            this.address = address;
            this.mobilePhone = mobilePhone;
            this.email = mail;
            this.course = course;
            this.specialty = spec;
            this.university = uni;
            this.faculty = fac;
        }

        public string GetFirstName
        {
            get { return this.firstName; }
        }

        public string GetLastName
        {
            get { return this.lastName; }
        }

        public string GetAddress
        {
            get { return this.address; }
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }
            if (!(this.GetFirstName == student.GetFirstName && this.lastName == student.lastName && this.GetAddress == student.GetAddress))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public object Clone()
        {
            //Add implementations of the ICloneable interface.
            //    The Clone() method should deeply copy all object's fields into a new object of type Student.

            Student original = this;
            object valueOriginal = original;
            return valueOriginal;           
        }

        public int CompareTo(Student other)
        {
            //Implement the  IComparable<Student> interface to compare students by names 
            //    (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

            if ((this.firstName + this.lastName) != (other.firstName + other.lastName))
            {
                return (this.firstName.CompareTo(other.firstName));
            }

            if (this.SSN != other.SSN)
            {
                return this.SSN + other.SSN;
            }

            return -1;
        }
    }   
}