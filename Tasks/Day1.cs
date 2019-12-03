using System;
namespace Adventofcode2019.Tasks
{
    public class Day1: BaseTask,ITask
    {
        int retval = 0;
        int retval2 = 0;

        public override string Run()
        {
            foreach(string line in this.Input)
            {
                retval += calc(int.Parse(line));
            }

            return retval.ToString();
        }

        public override string Run2()
        {
            foreach (string line in this.Input)
            {
                retval2 += calc2(int.Parse(line));
            }
            
            return retval2.ToString();
        }

        private int calc(int mass)
        {
            return ((int)(mass / 3)) - 2;
        }

        private int calc2(int mass)
        {
            int fuel = calc(mass);

            if(fuel < 1)
            {
                return 0;
            }
            else
            {
                return fuel + calc2(fuel);
            }
            
        }
    }
}
