namespace School
{
    public static class SchoolSystem
    {
        public static void Main()
        {
            School newSchool = new School("Telerik Academy");
            Class first = new Class("12A");
            Class second = new Class("10B");

            Teacher teacher = new Teacher("Nakov");
            first.AddTeacher(teacher);
            newSchool.AddClass(first);
            newSchool.AddClass(second);
        }
    }
}
