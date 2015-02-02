using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class MainMenu
    {
        static void Main()
        {
            
            List<Student> studList = new List<Student>();
            studList.Add(new Student(3));
            studList.Add(new Student(2));
            studList.Add(new Student(4));
            studList.Add(new Student(1));
            studList.Add(new Student(5));
            studList.Add(new Student(9));
            studList.Add(new Student(7));
            studList.Add(new Student(8));
            studList.Add(new Student(6));
            studList.Add(new Student(10));

            var sortedByGrade = from student in studList
                                orderby student.GetGrade
                                select student;


            List<Worker> workerList = new List<Worker>();
            workerList.Add(new Worker(300,8));
            workerList.Add(new Worker(350,10));
            workerList.Add(new Worker(500,8));
            workerList.Add(new Worker(600,7));
            workerList.Add(new Worker(1000,10));
            workerList.Add(new Worker(1500,8));
            workerList.Add(new Worker(250,6));
            workerList.Add(new Worker(450,5));
            workerList.Add(new Worker(550,8));
            workerList.Add(new Worker(650,8));

            var sortedWorkersByMoneyPerHour = from worker in workerList
                                              orderby worker.MoneyPerHour() descending
                                              select worker;

            foreach (var item in sortedWorkersByMoneyPerHour)
            {
                Console.WriteLine(item.Salary);
            }

            List<Human> mergeList = new List<Human>();

            foreach (var item in studList)
            {
                mergeList.Add(item);
            }

            foreach (var item in workerList)
            {
                mergeList.Add(item);
            }

            var sortedMergeList = from person in mergeList
                                  orderby person.FirstName
                                  select person;

            foreach (var item in sortedMergeList)
            {
                Console.WriteLine(item.FirstName);
            }

            
        }
    }
}
