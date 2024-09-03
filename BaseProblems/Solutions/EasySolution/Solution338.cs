namespace BaseProblems.Solutions.EasySolution
{
    public class Solution338
    {
        public int[] CountBits(int n)
        {
            var arr = new int[n + 1];
            var valueTwoInPower = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    arr[i] = arr[i - 1] + 1;
                }
                else if (i == valueTwoInPower * 2)
                {
                    arr[i] = 1;
                    valueTwoInPower *= 2;
                }
                else
                {
                    arr[i] = arr[valueTwoInPower] + arr[i - valueTwoInPower];
                }
            }

            return arr;
        }
    }
}