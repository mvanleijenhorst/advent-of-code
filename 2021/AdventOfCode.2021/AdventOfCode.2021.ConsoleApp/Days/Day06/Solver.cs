namespace AdventOfCode._2021.ConsoleApp.Days.Day06;

public class Solver: ISolver
{
    private const string NUMBERSEPERATOR = ",";

    public int Days { get; set; }   

    public long Solution01(string input)
    {
        var fishList = input
            .Split(NUMBERSEPERATOR)
            .Select(t => long.Parse(t))
            .ToList();

        var days = new long[9];

        days[0] = fishList.Where(d => d == 0).Count();
        days[1] = fishList.Where(d => d == 1).Count();
        days[2] = fishList.Where(d => d == 2).Count();
        days[3] = fishList.Where(d => d == 3).Count();
        days[4] = fishList.Where(d => d == 4).Count();
        days[5] = fishList.Where(d => d == 5).Count();
        days[6] = fishList.Where(d => d == 6).Count();
        days[7] = fishList.Where(d => d == 7).Count();
        days[8] = fishList.Where(d => d == 8).Count();

        for (int dayIndex = 0; dayIndex < 80; dayIndex++)
        {
            var previousDay = days.Select(d => d).ToArray();

            var newFish = previousDay[0];
            days[7] = previousDay[8];
            days[6] = previousDay[7] + newFish;
            days[5] = previousDay[6];
            days[4] = previousDay[5];
            days[3] = previousDay[4];
            days[2] = previousDay[3];
            days[1] = previousDay[2];
            days[0] = previousDay[1];
            days[8] = newFish;
        }

        return days.Sum();
    }

    public long Solution02(string input)
    {
        var fishList = input
            .Split(NUMBERSEPERATOR)
            .Select(t => long.Parse(t))
            .ToList();

        var days = new long[9];

        days[0] = fishList.Where(d => d == 0).Count();
        days[1] = fishList.Where(d => d == 1).Count();
        days[2] = fishList.Where(d => d == 2).Count();
        days[3] = fishList.Where(d => d == 3).Count();
        days[4] = fishList.Where(d => d == 4).Count();
        days[5] = fishList.Where(d => d == 5).Count();
        days[6] = fishList.Where(d => d == 6).Count();
        days[7] = fishList.Where(d => d == 7).Count();
        days[8] = fishList.Where(d => d == 8).Count();

        for (int dayIndex = 0; dayIndex < 256; dayIndex++)
        {
            var previousDay = days.Select(d => d).ToArray();

            var newFish = previousDay[0];
            days[7] = previousDay[8];
            days[6] = previousDay[7] + newFish;
            days[5] = previousDay[6];
            days[4] = previousDay[5];
            days[3] = previousDay[4];
            days[2] = previousDay[3];
            days[1] = previousDay[2];
            days[0] = previousDay[1];
            days[8] = newFish;
        }

        return days.Sum();
    }

}

