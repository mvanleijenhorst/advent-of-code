namespace AdventOfCode._2021.ConsoleApp.Days.Day04;

public class Solver : ISolver
{
    private const string NEWLINE = "\r\n";
    private const int NUMBERS = 0;
    private const int GRIDSIZE = 5;

    public long Solution01(string input)
    {
        var lines = input.Split(NEWLINE);
        var boards = new List<Board>();

        var numbers = lines[NUMBERS].Split(",").Select(t => int.Parse(t)).ToArray();

        lines = lines.Skip(1).ToArray();
        while (lines.Any())
        {
            var gridLines = lines.Skip(1).Take(GRIDSIZE);
            var grid = gridLines
                .Select(l => l.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => int.Parse(t))
                    .ToArray()
                ).ToArray();
            var board = new Board(grid);
            boards.Add(board);  

            lines = lines.Skip(1 + GRIDSIZE).ToArray();
        }

        foreach (var number in numbers)
        {
            var board = boards.FirstOrDefault(b => b.HasBingo(number));
            if (board != null)
            { 
                return board.Value(number);
            }
        }

        return 0;
    }


    public long Solution02(string input)
    {
        var lines = input.Split(NEWLINE);
        var boards = new List<Board>();

        var numbers = lines[NUMBERS].Split(",").Select(t => int.Parse(t)).ToArray();

        lines = lines.Skip(1).ToArray();
        while (lines.Any())
        {
            var gridLines = lines.Skip(1).Take(GRIDSIZE);
            var grid = gridLines
                .Select(l => l.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => int.Parse(t))
                    .ToArray()
                ).ToArray();
            var board = new Board(grid);
            boards.Add(board);

            lines = lines.Skip(1 + GRIDSIZE).ToArray();
        }

        foreach (var number in numbers)
        {
            if (boards.Count == 1)
            {
                if (boards.Where(b => b.HasBingo(number)).Any())   
                    return boards.First().Value(number);

            }
            else
            {
                var selectedBoards = boards.Where(b => b.HasBingo(number)).ToList();
                if (selectedBoards != null)
                {
                    foreach (var board in selectedBoards)
                    {
                        boards.Remove(board);
                    }
                }
            }
        }

        return 0;
    }

    internal class Board
    {
        private readonly int[][] _grid;
        private readonly List<int> _markedNumbers;
        
        internal Board(int[][] grid)
        {
            _grid = grid;
            _markedNumbers = new List<int>();
        }

        internal bool HasBingo(int number)
        {
            _markedNumbers.Add(number);
            if (_grid.Any(r => r.All(r => _markedNumbers.Contains(r))))
            {
                return true;
            }

            for (int columnIndex = 0; columnIndex < GRIDSIZE; columnIndex++)
            {
                var column = _grid.Select(r => r[columnIndex]).OrderBy(t => t).ToArray();
                if (column.All(c => _markedNumbers.Contains(c)))
                {
                    return true;
                }
            }

            return false;
        }

        internal int Value(int lastNumber)
        {
            var numbers = _grid.SelectMany(l => l.ToList());
            var sum = numbers.Where(n => !_markedNumbers.Contains(n)).Sum();
            return sum * lastNumber;
        }
    }
}

