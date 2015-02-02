namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {

        private List<Discipline> discipline;

        public Teacher(string name)
            :base(name)
        {
            this.discipline = new List<Discipline>();
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            this.discipline.Add(newDiscipline);
        }

        public void RemoveDiscipline(Discipline oldDiscipline)
        {
            this.discipline.Remove(oldDiscipline);
        }

    }
}
