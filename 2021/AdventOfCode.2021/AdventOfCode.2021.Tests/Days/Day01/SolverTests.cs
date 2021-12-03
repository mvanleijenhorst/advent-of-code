using AdventOfCode._2021.ConsoleApp.Days.Day01;
namespace AdventOfCode._2021.Tests.Days.Day01;

public class SolverTests
{
    private static string _input = TestDayResources.Day01;

    [Fact]
    public void Assigment01Test()
    {

        var sut = new Solver();
        var result = sut.Solution01(_input);

        result.Should().Be(7);
    }

    [Fact]
    public void Assigment02Test()
    {
        var input = TestDayResources.Day01;

        var sut = new Solver();
        var result = sut.Solution02(_input);

        result.Should().Be(5);
    }
}

