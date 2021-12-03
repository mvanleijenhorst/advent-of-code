using AdventOfCode._2021.ConsoleApp.Days.Day04;
namespace AdventOfCode._2021.Tests.Days.Day04;

public class SolverTests
{
    [Fact]
    public void Assigment01Test()
    {
        var input = TestDayResources.Day02;

        var sut = new Solver();
        var result = sut.Solution01(input);

        result.Should().Be(0);
    }

    [Fact]
    public void Assigment02Test()
    {
        var input = TestDayResources.Day02;

        var sut = new Solver();
        var result = sut.Solution02(input);

        result.Should().Be(0);
    }
}

