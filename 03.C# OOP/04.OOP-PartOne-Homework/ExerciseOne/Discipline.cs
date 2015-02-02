using ExerciseOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : IComments
    {
        private string disciplineName;
        private int numberOfLecture;
        private int numberOfExercise;

        public Discipline(string name,int lectures,int exercises)
        {
            this.disciplineName = name;
            this.numberOfLecture = lectures;
            this.numberOfExercise = exercises;
        }

        public string GetDiscipline
        {
            get
            {
                return this.disciplineName;
            }
        }

        public void AddComment(string something)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(string comment)
        {
            throw new NotImplementedException();
        }
    }
}
