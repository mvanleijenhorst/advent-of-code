namespace AdventOfCode._2021.ConsoleApp.Days.Day04;

public class Solver : ISolver
{
    private const string NEWLINE = "\r\n";
    private const int NUMBERS = 0;
    private const int GRIDSIZE = 5; 

    public int Solution01(string input)
    {
        var lines = input.Split(NEWLINE);
        var boards = new List<int[][]>();

        var numbers = lines[NUMBERS].Split(",").Select(t => int.Parse(t));
        var numberOfGrids = lines.Where(l => string.IsNullOrWhiteSpace(l)).Count();

        lines = lines.Skip(1).ToArray();

        for (int index = 0; index < numberOfGrids; index++) 
        {
            var gridLines = lines.Skip(1).Take(GRIDSIZE);
            var grid = gridLines.Select(l => l.Split(" ")).ToArray();
            //boards.Add(grid);

            lines = lines.Skip(6).ToArray();
        }

        return 0;
    }

    public int Solution02(string input)
    {
        throw new NotImplementedException();
    }

}

