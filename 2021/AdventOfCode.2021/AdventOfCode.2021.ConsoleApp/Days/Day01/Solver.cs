namespace AdventOfCode._2021.ConsoleApp.Days.Day01;

public class Solver : ISolver
{
    private const string NEWLINE = "\n";

    public int Solution01(string input)
    {
        var values = input.Split(NEWLINE);

        var increased = 0;
        for (int index = 1; index < values.Length; index++)
        {
            var previousValue = int.Parse(values[index - 1]);
            var currentValue = int.Parse((values[index]));

            if (currentValue > previousValue)
            {
                increased++;
            }
        }

        return increased;
    }

    public int Solution02(string input)
    {
        var values = input.Split(NEWLINE);

        var groupValues = new List<int>();
        for (int index = 2; index < values.Length; index++)
        {
            var value1 = int.Parse(values[index - 2]);
            var value2 = int.Parse((values[index - 1]));
            var value3 = int.Parse((values[index]));

            groupValues.Add(value1 + value2 + value3);
        }

        var increased = 0;
        for (int index = 1; index < groupValues.Count; index++)
        {
            var previousValue = groupValues[index - 1];
            var currentValue = groupValues[index];

            if (currentValue > previousValue)
            {
                increased++;
            }
        }

        return increased;
    }
}

