using AdventOfCode._2021.ConsoleApp.Days.Day03;
namespace AdventOfCode._2021.Tests.Days.Day03;

public class SolverTests
{
    private static string _input = TestDayResources.Day03;

    [Fact]
    public void Assigment01Test()
    {
        var sut = new Solver();
        var result = sut.Solution01(_input);

        result.Should().Be(198);
    }

    [Fact]
    public void Assigment02Test()
    {
        var sut = new Solver();
        var result = sut.Solution02(_input);

        result.Should().Be(230);
    }
}

