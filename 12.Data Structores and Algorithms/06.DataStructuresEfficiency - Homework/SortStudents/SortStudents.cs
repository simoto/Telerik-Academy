namespace SortStudents
{
    /*
     * Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the
     * students ordered by family and then by name:
     */

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SortStudents
    {
        static void Main()
        {
            SortedDictionary<string, List<Student>> sortedDic = new SortedDictionary<string, List<Student>>();
            string[] splitted;
            using (StreamReader sr = new StreamReader("../../students.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    splitted = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = splitted[0].Trim();
                    string familyName = splitted[1].Trim();
                    string course = splitted[2].Trim();

                    var obj = new Student
                        {
                            FirstName = firstName,
                            FamilyName = familyName
                        };

                    if (sortedDic.ContainsKey(course))
                    {
                        sortedDic[course]
                            .Add(obj);
                    }
                    else
                    {
                        sortedDic.Add(course, new List<Student>());
                        sortedDic[course].Add(obj);
                    }
                }
            }

            List<string> courseStudents;

            foreach (var courses in sortedDic)
            {
                courseStudents = new List<string>();

                Console.Write(courses.Key + ": ");
                var query = courses.Value.OrderBy(x => x.FamilyName).ThenBy(y => y.FirstName).ToList();
                foreach (var student in query)
                {
                    courseStudents.Add(string.Format("{0} {1}", student.FirstName, student.FamilyName));
                }
                Console.WriteLine(string.Join(", ", courseStudents));
            }
        }
    }
}