namespace BaseProblems.Solutions.EasySolution;

public class Solution2409
{
    private readonly int[] monthDays = [0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334];

    public int CountDaysTogether(
        string arriveAlice,
        string leaveAlice,
        string arriveBob,
        string leaveBob
    )
    {
        var arriveAliceDays = ParseDate(arriveAlice);
        var leaveAliceDays = ParseDate(leaveAlice);
        var arriveBobDays = ParseDate(arriveBob);
        var leaveBobDays = ParseDate(leaveBob);

        var result =
            Math.Min(leaveAliceDays, leaveBobDays) - Math.Max(arriveAliceDays, arriveBobDays) + 1;

        return Math.Max(result, 0);
    }

    private int ParseDate(string date)
    {
        var month = int.Parse(date[..2]);
        var day = int.Parse(date[3..5]);

        return monthDays[month - 1] + day;
    }
}
