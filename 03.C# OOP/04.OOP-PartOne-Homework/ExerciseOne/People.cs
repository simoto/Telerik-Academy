namespace School
{
    using ExerciseOne;
    using System;

    public abstract class People : IComments
    {
        protected string name;

        public People()
        {         
        }

        public People(string name)
        {
            this.name = name;
        }

        public string GetName
        {
            get
            {
                return this.name;
            }
        }

        public void AddComment(string comment)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(string comment)
        {
            throw new NotImplementedException();
        }
    }
}