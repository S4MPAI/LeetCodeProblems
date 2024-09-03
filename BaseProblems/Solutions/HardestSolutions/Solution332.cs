using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution332
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var airportsTree = new Dictionary<string, List<string>>();
            
            foreach (var ticketsItem in tickets)
            {
                if (!airportsTree.ContainsKey(ticketsItem[0]))
                    airportsTree[ticketsItem[0]] = new List<string>();
                airportsTree[ticketsItem[0]].Add(ticketsItem[1]);
            }

            foreach (var key in airportsTree.Keys)
                airportsTree[key].Sort((a, b) => b.CompareTo(a));

            var stack = new Stack<string>();
            stack.Push("JFK");
            var result = new List<string>();

            while (stack.Count > 0)
            {
                var airport = stack.Peek();
                if (airportsTree.ContainsKey(airport) && airportsTree[airport].Count > 0)
                {
                    stack.Push(airportsTree[airport].Last());
                    airportsTree[airport].RemoveAt(airportsTree[airport].Count - 1);
                }
                else
                {
                    result.Add(airport);
                    stack.Pop();
                }
            }

            result.Reverse();
            return result;
        }
    }
}
