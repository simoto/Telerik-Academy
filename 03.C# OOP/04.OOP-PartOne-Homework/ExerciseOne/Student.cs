namespace School
{
    using System;

    public class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber)
            :base(name)
        {
            this.classNumber = classNumber;
        }

        public Student(int classNumber)
        {
            this.classNumber = classNumber;
        }
    }
}