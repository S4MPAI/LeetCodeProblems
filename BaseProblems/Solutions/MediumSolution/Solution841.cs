using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution841
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new HashSet<int>();
            var stack = new Stack<int>();
            stack.Push(0);
            visited.Add(0);

            while (stack.Any())
            {
                var key = stack.Pop();
                
                foreach (var x in rooms[key])
                {
                    if (!visited.Contains(x))
                    {
                        visited.Add(x);
                        stack.Push(x);
                    }
                }
            }

            return visited.Count == rooms.Count;
        }
    }
}
