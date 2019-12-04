using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventofcode2019.Tasks
{
    public class Day4: BaseTask,ITask
    {
        public Day4()
        {
        }

        public override string Run()
        {
            int hit = 0;
            (int, int) input = ParseInput(Input[0]);

            for(int i = input.Item1;i < input.Item2; i++)
            {
                if(Rule1(i) && Rule2(i))
                {
                    hit++;
                }
            }

            return hit.ToString();
        }

        public override string Run2()
        {
            int hit = 0;
            (int, int) input = ParseInput(Input[0]);

            for (int i = input.Item1; i < input.Item2; i++)
            {
                if (Rule1(i) && Rule2(i) && Rule3(i))
                {
                    hit++;
                }
            }

            return hit.ToString();

        }

        private (int,int) ParseInput(string input)
        {
            return (int.Parse(input.Split('-')[0]), int.Parse(input.Split('-')[1]));
        }

        public bool Rule1(int number)
        {
            string s = number.ToString();
            char last = 'a';

            foreach(char c in s)
            {
                if(c == last)
                {
                    return true;
                }
                else
                {
                    last = c;
                }
            }

            return false;
        }

        public bool Rule2(int number)
        {
            string s = number.ToString();
            char last = '0';

            foreach (char c in s)
            {
                if (c < last)
                {
                    return false;
                }
                else
                {
                    last = c;
                }
            }

            return true;
        }

        public bool Rule3(int number)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            string s = number.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i])) d[s[i]]++;
                else d.Add(s[i], 1);
            }
            return d.Values.Any(v => v == 2);
        }

    }
}
