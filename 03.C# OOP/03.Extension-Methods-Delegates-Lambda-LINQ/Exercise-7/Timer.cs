//Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace Exercise_7
{
    using System;
    using System.Threading;

    class Timer
    {
        public delegate void MyDelegate(int parameter);

        static void Main()
        {
            DateTime myDate = new DateTime();

            MyDelegate a = new MyDelegate(Print);

            for (int i = 0; i < 10; i++)
            {
                
                myDate.AddSeconds(1);
                a(i);
                Thread.Sleep(1000);
            }    
        }

        public static void Print(int parameter)
        {          
            Console.WriteLine("{0} second",parameter);            
        }      
    }
}