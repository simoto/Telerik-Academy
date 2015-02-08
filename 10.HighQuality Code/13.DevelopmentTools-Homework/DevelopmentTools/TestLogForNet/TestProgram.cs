namespace TestLogForNet
{
    using System;
    using System.Text;
    using log4net;
    using log4net.Config;


    class TestProgram
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TestProgram));
        static void Main()
        {
            BasicConfigurator.Configure();
            log.Info("application starts!");
            StringBuilder sb = new StringBuilder();
            log.Info("added string builder!");
            Console.WriteLine("End of the program");
            log.Info("the program ends");
        }
    }
}
