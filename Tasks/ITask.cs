using System;
namespace Adventofcode2019.Tasks
{
    public interface ITask
    {
        string[] Input { get; set; }
        string Run();
        string Run2();
    }
}
