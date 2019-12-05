using System;
namespace Adventofcode2019.Tasks
{
    public class IntCodeComputer
    {
        private int[] program;
        private int pointer;
        public IntCodeComputer()
        {
        }

        public int[] Run(int[] program)
        {
            //1,1,1,4,99,5,6,0,99 becomes 30,1,1,4,2,5,6,0,99.
            this.program = program;
            pointer = 0;
            while (true)
            {
                int step = Evaluate(pointer);
                pointer += step;
                if (step == 0)
                {
                    break;
                }
            }
            return this.program;
        }

        private void Add(int p1, int p2, int res)
        {
            program[res] = program[p1] + program[p2];
        }

        private void Multiply(int p1, int p2, int res)
        {
            program[res] = program[p1] * program[p2];
        }

        private void Set(int val, int pos)
        {
            program[pos] = val;
        }

        private int Get(int pos)
        {
            return program[pos];
        }

        private int Opcode(int instruction)
        {
            return instruction % 100;
        }

        //private (int,int,int) Params(int position)
        //{
            //return instruction % 100;
        //}

        private int Evaluate(int position)
        {
            

            switch (Opcode(program[position]))
            {
                case 1:
                        Add(program[position + 1], program[position + 2], program[position + 3]);
                    return 4;
                    
                case 2:
                        Multiply(program[position + 1], program[position + 2], program[position + 3]);
                    return 4;
                case 3:
                    Set(1, program[position + 1]);
                    return 1;
                case 99:
                    return 0;
                default:
                    throw new Exception("Unknown OPCODE:" + program[position] + " at position " + position); 

            }
        }   
    }
}