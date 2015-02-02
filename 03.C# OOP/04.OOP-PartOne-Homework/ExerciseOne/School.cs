namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Class> classes;

        public School(string name)
        {
            this.name = name;
            this.classes = new List<Class>();
        }

        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }

        public void RemoveClass(Class oldClass)
        {
            this.classes.Remove(oldClass);
        }
    }
}