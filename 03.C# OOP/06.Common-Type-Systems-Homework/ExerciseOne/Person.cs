//Create a class Person with two fields – name and age. Age can be left unspecified 
//(may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace Exercises
{
    class Person
    {
        private string name;
        private byte? age;

        public Person(string name, byte? age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            string testName;
            string testAge;

            if (this.name == null)
            {
                testName = "Name is not specified";
            }
            else
            {
                testName = this.name;
            }

            if (this.age == null)
            {
                testAge = "Age is not specified";
            }
            else
            {
                testAge = this.age.ToString();
            }

            return string.Format("Name: {0}\nAge: {1}", testName, testAge);
        }
    }
}