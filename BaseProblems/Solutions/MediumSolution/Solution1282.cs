using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1282
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var result = new List<IList<int>>();
            var groupDictionary = new Dictionary<int, List<int>>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                var group = groupSizes[i];
                if (!groupDictionary.ContainsKey(group))
                    groupDictionary.Add(group, new List<int>());

                groupDictionary[groupSizes[i]].Add(i);

                if (groupDictionary[group].Count == group)
                {
                    result.Add(groupDictionary[group]);
                    groupDictionary[group] = new List<int>();
                }
            }

            return result;
        }
    }
}
