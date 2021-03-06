using AdventOfCode._2021.ConsoleApp.Days.Day05;
namespace AdventOfCode._2021.Tests.Days.Day05;

public class SolverTests
{
    [Fact]
    public void Assigment01Test()
    {
        var input = TestDayResources.Day05;

        var sut = new Solver();
        var result = sut.Solution01(input);

        result.Should().Be(5);
    }

    [Fact]
    public void Assigment02Test()
    {
        var input = TestDayResources.Day05;

        var sut = new Solver();
        var result = sut.Solution02(input);

        result.Should().Be(12);
    }
}

