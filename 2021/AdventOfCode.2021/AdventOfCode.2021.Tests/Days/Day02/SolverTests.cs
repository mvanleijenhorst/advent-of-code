using AdventOfCode._2021.ConsoleApp.Days.Day02;
namespace AdventOfCode._2021.Tests.Days.Day02;

public class SolverTests
{
    private static string _input = TestDayResources.Day02;

    [Fact]
    public void Assigment01Test()
    {
        var sut = new Solver();
        var result = sut.Solution01(_input);

        result.Should().Be(150);
    }

    [Fact]
    public void Assigment02Test()
    {
        var sut = new Solver();
        var result = sut.Solution02(_input);

        result.Should().Be(900);
    }
}

