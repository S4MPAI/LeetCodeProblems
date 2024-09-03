using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution901
    {
        public class StockSpanner
        {
            Stack<(int stock, int span)> stockSpan;

            public StockSpanner()
            {
                stockSpan = new();
            }

            public int Next(int price)
            {
                var currentSpan = 1;

                while (stockSpan.Count > 0 && price >= stockSpan.Peek().stock)
                {
                    var span = stockSpan.Pop().span;
                    currentSpan += span;
                }

                stockSpan.Push((price, currentSpan));
                return currentSpan;
            }
        }
    }
}
