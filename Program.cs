using System;
using System.IO;
using Adventofcode2019.Tasks;

namespace Adventofcode2019
{
    class MainClass
    {
        private const int day = 4;

        public static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Welcome! - Running task day{0}.cs",day));
            ITask task = (ITask)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(string.Format("Adventofcode2019.Tasks.Day{0}", day));
            task.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", day));
            string res = task.Run();
            string res2 = task.Run2();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
