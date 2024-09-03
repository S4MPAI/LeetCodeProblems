using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution380
    {
        public class RandomizedSet
        {
            public readonly Dictionary<int, int> indexes;
            public readonly List<int> values;
            public readonly Random random;

            public RandomizedSet()
            {
                values = new List<int>();
                indexes = new Dictionary<int, int>();
                random = new Random();
            }

            public bool Insert(int val)
            {
                if (indexes.ContainsKey(val))
                    return false;

                values.Add(val);
                indexes[val] = values.Count - 1;
                return true;
            }

            public bool Remove(int val)
            {
                if (!indexes.ContainsKey(val))
                    return false;

                var lastValue = values[^1];
                var valIndex = indexes[val];

                values[valIndex] = lastValue;
                indexes[lastValue] = valIndex;

                values.RemoveAt(values.Count - 1);
                indexes.Remove(val);

                return true;
            }

            public int GetRandom()
            {
                var index = random.Next(values.Count);
                return values[index];
            }
        }
    }
}
