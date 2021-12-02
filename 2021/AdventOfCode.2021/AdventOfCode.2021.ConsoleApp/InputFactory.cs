using AdventOfCode._2021.ConsoleApp.Days;

namespace AdventOfCode._2021.ConsoleApp;

internal class InputFactory
{
    public static string CreateInput(ISolver solver)
    {
        switch (solver)
        {
            case Days.Day01.Solver:
                return DayResources.Day01;
            case Days.Day02.Solver:
                return DayResources.Day02;
            //case Days.Day03.Solver:
            //    return DayResources.Day03;
        }

        throw new NotImplementedException($"No input found for Solver of type '{solver?.GetType()}'");
    }
}
