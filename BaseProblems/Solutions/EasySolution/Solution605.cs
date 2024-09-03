using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    var isLeftFreeSpot = (i == 0) || flowerbed[i - 1] == 0;
                    var isRightFreeSpot = (i == flowerbed.Length - 1) || flowerbed[i + 1] == 0;

                    if (isLeftFreeSpot && isRightFreeSpot)
                    {
                        flowerbed[i] = 1;
                        n--;
                        if (n == 0)
                            break;
                    }
                }
            }

            return n <= 0;
        }
    }
}
