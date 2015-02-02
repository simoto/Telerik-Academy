namespace School
{
    using ExerciseOne;

    using System;
    using System.Collections.Generic;

    public class Class : IComments
    {
        private List<Student> studentList;
        private List<Teacher> teacherList;
        private string classIdentifier;

        public Class(string classIdentifier)
        {
            this.classIdentifier = classIdentifier;
            this.studentList = new List<Student>();
            this.teacherList = new List<Teacher>();
        }

        public string GetIdentifier
        {
            get
            {
                return this.classIdentifier;
            }
        }

        public void AddStudent(Student newStudent)
        {
            this.studentList.Add(newStudent);
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.teacherList.Add(newTeacher);
        }

        public void RemoveStudent(Student oldStudent)
        {
            this.studentList.Remove(oldStudent);
        }

        public void RemoveTeacher(Teacher oldTeacher)
        {
            this.teacherList.Remove(oldTeacher);
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
