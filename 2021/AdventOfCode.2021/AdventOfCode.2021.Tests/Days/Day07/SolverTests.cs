﻿using AdventOfCode._2021.ConsoleApp.Days.Day06;
namespace AdventOfCode._2021.Tests.Days.Day07;

public class SolverTests
{
    private static string _input = TestDayResources.Day06;

    [Fact]
    public void Assigment01Test()
    {
        var sut = new Solver();
        var result = sut.Solution01(_input);

        result.Should().Be(0);
    }

    [Fact]
    public void Assigment02Test()
    {
        var sut = new Solver();
        var result = sut.Solution02(_input);

        result.Should().Be(0);
    }
}

