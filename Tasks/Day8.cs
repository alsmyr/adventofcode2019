using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventofcode2019.Tasks
{
    public class Day8: BaseTask,ITask
    {
        public Day8()
        {
        }

        public override string Run()
        {
            SpaceImage spaceImage = new SpaceImage(this.Input[0], 25, 6);
            int i = spaceImage.GetAnswer1();

            return i.ToString();
        }

        public override string Run2()
        {
            SpaceImage spaceImage = new SpaceImage(this.Input[0], 25, 6);
            spaceImage.WriteAnswer2();

            return "";
        }

        class SpaceImage
        {
            public Layer[] Layers;

            private int FindIt()
            {
                int? low = null;
                int pos = 0;

                for (int x = 0; x < Layers.Length; x++)
                {
                    int current = Layers[x].CountZeros();

                    if (low > current || low == null)
                    {
                        low = current;
                        pos = x;
                    }
                }

                return pos;
            }

            public int GetAnswer1()
            {
                return Layers[FindIt()].Count1x2();
            }

            public Layer Find()
            {
                int width = Layers[0].Width;
                int height = Layers[0].Height;

                char[] data = new char[height * width];

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        char val = 'f';

                        foreach (Layer layer in Layers)
                        {
                            char rowValue = layer.GetValueAtIndex(x, y);

                            if (rowValue == '0')
                            {
                                val = ' ';
                                break;
                            }

                            if (rowValue == '1')
                            {
                                val = '☺';
                                break;
                            }
                        }

                        data[x + y * width] = val;
                    }
                }

                return new Layer(data, width, height);
            }

            public void WriteAnswer2()
            {
                Layer layer = Find();

                char[][] pic = layer.Picture;

                foreach (char[] line in pic)
                {
                    Console.WriteLine(new string(line));
                }
            }

            public SpaceImage(string str, int width, int height)
            {
                int l = width * height;
                int n = str.Length / l;

                List<Layer> layers = new List<Layer>();
                for (int x = 0; x < n; x++)
                {
                    layers.Add(new Layer(str.Skip(x * l).Take(l).ToArray(), width, height));
                }

                Layers = layers.ToArray();
            }
        }

        class Layer
        {
            private char[] Data;
            public int Height;
            public int Width;

            public char GetValueAtIndex(int x, int y)
            {
                return Data[x + y * Width];
            }

            public int CountZeros()
            {
                int z = 0;

                foreach (char value in Data)
                {
                    if (value - '0' == 0)
                    {
                        z++;
                    }
                }

                return z;
            }

            public int Count1x2()
            {
                int c1 = 0;
                int c2 = 0;

                foreach (int value in Data)
                {
                    if (value - '0' == 1)
                    {
                        c1++;
                    }

                    if (value - '0' == 2)
                    {
                        c2++;
                    }
                }

                return c1 * c2;
            }

            public char[][] Picture
            { 
                get {
                    List<char[]> rows = new List<char[]>();

                    for (int y = 0; y < Height; y++)
                    {
                        char[] row = Data.Skip(y * Width).Take(Width).ToArray();
                        rows.Add(row);
                    }

                    return rows.ToArray();
                }
            }

            public Layer(char[] data, int width, int height)
            {
                Data = data;
                Height = height;
                Width = width;
            }
        }
    }
}
