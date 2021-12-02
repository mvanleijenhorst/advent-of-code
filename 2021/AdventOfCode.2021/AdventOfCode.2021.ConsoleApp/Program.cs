using AdventOfCode._2021.ConsoleApp.Days.Day03;

var solver = new Solver();
var input = InputFactory.CreateInput(solver);

Console.WriteLine($"Answer challange 1: {solver.Solution01(input)}");
Console.WriteLine($"Answer challange 2: {solver.Solution02(input)}");

Console.WriteLine();
Console.WriteLine("Press any key");
Console.ReadKey();
