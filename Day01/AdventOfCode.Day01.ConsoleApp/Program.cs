// See https://aka.ms/new-console-template for more information
using AdventOfCode.Day01.ConsoleApp;

var text = ResourceData.SonarData;
var increased = 0;

var values = text.Split("\n");
for (int index = 1; index < values.Length; index++)
{
    var previousValue = int.Parse(values[index - 1]);
    var currentValue = int.Parse((values[index]));

    if (currentValue > previousValue)
    {
        increased++;
    }
}

Console.WriteLine($"Answer question 1: {increased}");

var groupValues = new List<int>();
for (int index = 2; index < values.Length; index++)
{
    var value1 = int.Parse(values[index - 2]);
    var value2 = int.Parse((values[index- 1]));
    var value3 = int.Parse((values[index]));

    groupValues.Add(value1 + value2 + value3);
}

increased = 0;  
for (int index = 1; index < groupValues.Count; index++)
{
    var previousValue = groupValues[index - 1];
    var currentValue = groupValues[index];

    if (currentValue > previousValue)
    {
        increased++;
    }
}

Console.WriteLine($"Answer question 1: {increased}");
