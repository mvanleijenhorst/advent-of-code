namespace AdventOfCode._2021.ConsoleApp.Days.Day05;

public class Solver : ISolver
{
    private const string NEWLINE = "\r\n";

    public int Solution01(string input)
    {
        var textLines = input.Split(NEWLINE);

        var lines = textLines
            .Select(line => line.Split(" -> ")
                .SelectMany(point => point.Split(",")
                    .Select(number => int.Parse(number))
                ).ToArray())
            .Select(c => new Line(c[0], c[1], c[2], c[3]))
            .Where(c => c.LineType != LineType.Diagonal)
            .ToArray();

        var points = lines
            .SelectMany(l => l.Points().ToList())
            .GroupBy(p => new {X = p[0], Y = p[1]})
            .Select(gp => new { Point = gp, Count = gp.Count() })
            .ToList();

        return points.Where(p => p.Count > 1).Count();
    }

    public int Solution02(string input)
    {
        var textLines = input.Split(NEWLINE);

        var lines = textLines
            .Select(line => line.Split(" -> ")
                .SelectMany(point => point.Split(",")
                    .Select(number => int.Parse(number))
                ).ToArray())
            .Select(c => new Line(c[0], c[1], c[2], c[3]))
            .ToArray();

        var points = lines
            .SelectMany(l => l.Points().ToList())
            .GroupBy(p => new { X = p[0], Y = p[1] })
            .Select(gp => new { Point = gp, Count = gp.Count() })
            .ToList();

        return points.Where(p => p.Count > 1).Count();
    }



    internal enum LineType
    {
        Horizontal,
        Vertical,
        Diagonal
    }

    internal record Line(int X1, int Y1, int X2, int Y2)
    {
        private int MinX => Math.Min(X1, X2);
        private int MaxX => Math.Max(X1, X2);
        private int MinY => Math.Min(Y1, Y2);
        private int MaxY => Math.Max(Y1, Y2);

        internal List<int[]> Points()
        {
            var result = new List<int[]>(); 
            switch (LineType)
            {
                case LineType.Horizontal:
                    for (var x = MinX; x <= MaxX; x++)
                    {
                        result.Add(new int[] { x, Y1 });
                    }
                    break;
                case LineType.Vertical:
                    for (var y = MinY; y <= MaxY; y++)
                    {
                        result.Add(new int[] { X1, y});
                    }
                    break;
                case LineType.Diagonal:
                    if (X1 < X2)
                    {
                        var diff = X2 - X1;
                        for (var index = 0; index <= diff; index++)
                        {
                            if (Y1 < Y2)
                            {
                                result.Add(new int[] { X1 + index, Y1 + index });
                            }
                            else
                            {
                                result.Add(new int[] { X1 + index, Y1 - index });
                            }
                        }
                    }
                    else
                    {
                        var diff = X1 - X2;
                        for (var index = 0; index <= diff; index++)
                        {
                            if (Y1 < Y2)
                            {
                                result.Add(new int[] { X1 - index, Y1 + index });
                            }
                            else
                            {
                                result.Add(new int[] { X1 - index, Y1 - index });
                            }
                        }
                    }

                    break;
            }

            return result;
        }

        internal LineType LineType => Y1 == Y2 ? LineType.Horizontal : X1 == X2 ? LineType.Vertical : LineType.Diagonal;
    }

}

