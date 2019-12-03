using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Adventofcode2019.Tasks
{
    public class Day3: BaseTask,ITask
    {
        public Day3()
        {
        }

        public override string Run()
        {
            var a = Parse(Input[0]);
            var b = Parse(Input[1]);

            var i = a.Keys.Intersect(b.Keys);

            return (i.Min(x => Math.Abs(x.Item1) + Math.Abs(x.Item2))).ToString();
        }

        public override string Run2()
        {
            var a = Parse(Input[0]);
            var b = Parse(Input[1]);

            var i = a.Keys.Intersect(b.Keys);

            return "BAH!";

        }

        private int Manhattan(int x, int y)
        {
            return Math.Abs(x) + Math.Abs(y);
        }

        private Dictionary<(int, int), int> Parse(string input)
        {
            int x = 0;
            int y = 0;
            int c = 0;

            var panel = new Dictionary<(int, int), int>();
           
            foreach (var i in input.Split(','))
            {
                switch (i[0])
                {
                    case 'U':
                        for (int s = 0; s < int.Parse(i.Substring(1)); s++)
                        {
                            if (!panel.ContainsKey((x, ++y)))
                            {
                                panel.Add((x, y), c++);
                            }
                        }
                        break;

                    case 'D':
                        for (int s = 0; s < int.Parse(i.Substring(1)); s++)
                        {
                            if(!panel.ContainsKey((x, --y)))
                            {
                                panel.Add((x, y), c++);
                            }
                                
                        }
                        break;

                    case 'R':
                        for (int s = 0; s < int.Parse(i.Substring(1)); s++)
                        {
                            if (!panel.ContainsKey((++x, y)))
                            {
                                panel.Add((x, y), c++);
                            }
                        }
                        break;

                    case 'L':
                        for (int s = 0; s < int.Parse(i.Substring(1)); s++)
                        {
                            if (!panel.ContainsKey((--x, y)))
                            {
                                panel.Add((x, y), c++);
                            }
                        }
                        break;

                }
            }

            return panel;
        }
    }
}
