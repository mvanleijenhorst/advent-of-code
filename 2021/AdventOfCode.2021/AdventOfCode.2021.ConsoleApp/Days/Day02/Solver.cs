namespace AdventOfCode._2021.ConsoleApp.Days.Day02;

public class Solver : ISolver
{
    private const string NEWLINE = "\n";
    private const string SPACE = " ";
    private const string FORWARD = "forward";
    private const string DOWN = "down";
    private const string UP = "up";

    private const int ACTION = 0;
    private const int VALUE = 1;

    public long Solution01(string input)
    {
        var lines = input.Split(NEWLINE);

        var dept = 0;
        var forward = 0;

        foreach (var line in lines)
        {
            var records = line.Split(SPACE);
            var action = records[ACTION];
            var value = int.Parse(records[VALUE]);

            switch (action.ToLower())
            {
                case FORWARD:
                    forward += value;
                    break;
                case DOWN:
                    dept += value;
                    break;
                case UP:
                    dept -= value;  
                    break;
            }
        }

        return forward * dept;
    }

    public long Solution02(string input)
    {
        var lines = input.Split(NEWLINE);

        var forward = 0;
        var dept = 0;
        var aim = 0;

        foreach (var line in lines)
        {
            var records = line.Split(SPACE);
            var action = records[ACTION];
            var value = int.Parse(records[VALUE]);

            switch (action.ToLower())
            {
                case FORWARD:
                    forward += value;
                    dept += (aim * value);
                    break;
                case DOWN:
                    aim += value;
                    break;
                case UP:
                    aim -= value;
                    break;
            }
        }

        return forward * dept;
    }
}

