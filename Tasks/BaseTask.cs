using System;
namespace Adventofcode2019.Tasks
{
    public abstract class BaseTask:ITask
    {
        public string[] Input { get; set; }
        public abstract string Run();
        public abstract string Run2();
    }
}
