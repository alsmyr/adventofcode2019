using System;
namespace Adventofcode2019.Tasks
{
    public class Day2: BaseTask,ITask
    {
        public Day2()
        {
        }

        public override string Run()
        {
            IntCodeComputer c = new IntCodeComputer();

            string[] tokens = this.Input[0].Split(',');

            int[] program = Array.ConvertAll<string, int>(tokens, int.Parse);

            program[1] = 12;
            program[2] = 2;

            int[] result = c.Run(program);

            return result[0].ToString();
        }

        public override string Run2()
        {
            int query = 19690720;
            IntCodeComputer c = new IntCodeComputer();
            string[] tokens = this.Input[0].Split(',');

            int[] program = null;

            for (int noun = 0;noun < 100;noun++)
            {
                for (int verb = 0; verb < 100; verb++)
                {
                    program = Array.ConvertAll<string, int>(tokens, int.Parse);
                    program[1] = noun;
                    program[2] = verb;

                    int[] result = c.Run(program);

                    if(result[0] == query)
                    {
                        return (100 * noun + verb).ToString();
                    }
                }
            }

            return "BAH!";

        }
    }
}
