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
            while (Evaluate(pointer))
            {
                pointer += 4;
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

        private bool Evaluate(int position)
        {
            switch(program[position])
            {
                case 1:
                        Add(program[position + 1], program[position + 2], program[position + 3]);
                    return true;
                case 2:
                        Multiply(program[position + 1], program[position + 2], program[position + 3]);
                    return true;
                case 99:
                    return false;
                default:
                    throw new Exception("Unknown OPCODE:" + program[position] + " at position " + position); 

            }
        }   
    }
}