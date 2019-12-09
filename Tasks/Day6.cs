using System;
using System.Collections.Generic;
using System.Linq;

namespace Adventofcode2019.Tasks
{
    public class Day6: BaseTask,ITask
    {
        private static Dictionary<string, Planet> p = new Dictionary<string, Planet>();

        public Day6()
        {
        }

        public override string Run()
        {
            foreach (string line in Input)
            {
                Planet parent = FindOrAddPlanet(line.Substring(0, 3));
                Planet child = FindOrAddPlanet(line.Substring(4, 3));

                parent.AddChild(child);
            }

            return p.Values.Select(x => x.Tier).Sum().ToString();
        }

        public override string Run2()
        {
            if(p.Values.Count == 0)
            {
                foreach (string line in Input)
                {
                    Planet parent = FindOrAddPlanet(line.Substring(0, 3));
                    Planet child = FindOrAddPlanet(line.Substring(4, 3));

                    parent.AddChild(child);
                }
            }
            
            Planet p1 = p["YOU"].parent;
            Planet p2 = p["SAN"].parent;

            int dist = FindIt(p1, p2);

            return dist.ToString();

        }

        private static int FindIt(Planet start, Planet end)
        {
            Dictionary<Planet, int> distances = new Dictionary<Planet, int>();

            int distance = 0;
            Planet current = start;

            while (current != null)
            {
                distances.Add(current, distance);
                current = current.parent;
                distance++;
            }

            distance = 0;
            current = end;

            while (current != null)
            {
                if (distances.ContainsKey(current))
                {
                    return distance + distances[current];
                }

                distance++;
                current = current.parent;
            }

            throw new Exception("BAH!");
        }

        public static Planet FindOrAddPlanet(string n)
        {
            if (!p.ContainsKey(n))
            {
                p.Add(n, new Planet(n));
            }

            return p[n];
        }
    }

    /// <summary>
    /// Just a planet
    /// </summary>
    public class Planet
    {
        public string Name { get; }

        public Planet parent = null;
        public List<Planet> children = new List<Planet>();

        public int Tier
        {
            get
            {
                if (parent == null)
                {
                    return 0;
                }

                return parent.Tier + 1;
            }
        }

        public Planet(string name)
        {
            Name = name;
        }

        public void AddChild(Planet child)
        {
            children.Add(child);

            if (child.parent != null)
            {
                throw new Exception("Already coupled");
            }

            child.parent = this;
        }

        public IEnumerable<Planet> Connections()
        {
            foreach (Planet child in children)
            {
                yield return child;
            }

            if (parent != null)
            {
                yield return parent;
            }
        }
    }
}
