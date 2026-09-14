using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.EasySolution;

public class Solution9 : IStartable
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        var reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        return reversedHalf == x || x == reversedHalf / 10;
    }

    public void Start()
    {
        var a = int.Parse(Console.ReadLine());
        var b = IsPalindrome(a);
        Console.WriteLine(b);
    }
}
