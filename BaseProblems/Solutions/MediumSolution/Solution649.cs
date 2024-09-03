using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution649
    {
        public string PredictPartyVictory(string senate)
        {
            var queue = new Queue<char>(senate);
            var countD = queue.Count(x => x == 'D');
            var countR = queue.Count - countD;
            var bans = 0;

            while (countD > 0 && countR > 0) 
            {
                var player = queue.Dequeue();

                if ('R' == player)
                {
                    if (bans >= 0)
                    {
                        countD--;
                        queue.Enqueue(player);
                    }
                    bans++;
                }
                else
                {
                    if (bans <= 0)
                    {
                        countR--;
                        queue.Enqueue(player);
                    }
                    bans--;
                }
                
            }

            return countR == 0 ? "Dire" : "Radiant";
        }
    }
}
