using System.Text;

namespace AdventOfCode._2021.ConsoleApp.Days.Day03;

public class Solver : ISolver
{
    private const string NEWLINE = "\r\n";

    public long Solution01(string input)
    {
        var lines = input.Split(NEWLINE);
        var binarylength = lines.FirstOrDefault()?.Length ?? 0;

        var half = lines.Length / 2;
        var gamma = 0;
        var epsilon = 0;
        var value = (int)Math.Pow(2, binarylength - 1);

        for (int index = 0; index < binarylength; index++)
        {
            var count = lines.Select(l => int.Parse($"{l[index]}")).Sum();
            if (count > half)
            {
                gamma += value;
            }
            else
            {
                epsilon += value;
            }
            value /= 2;
        }

        return gamma * epsilon;
    }

    public long Solution02(string input)
    {
        var lines = input.Split(NEWLINE);
        var binarylength = lines.FirstOrDefault()?.Length ?? 0;

        var oxygenLines = OxygenGenerator(lines, binarylength, 0);
        var oxygen = oxygenLines.Select(line => Convert.ToInt32(line, 2)).FirstOrDefault();

        var co2Lines = CO2Scrubber(lines, binarylength, 0);
        var co2 = co2Lines.Select(line => Convert.ToInt32(line, 2)).FirstOrDefault();

        return co2 * oxygen;
    }

    private IEnumerable<string> OxygenGenerator(IEnumerable<string> lines, int binairyLength, int currentPos)
    {
        if (currentPos == binairyLength || lines.Count() == 1)
        {
            return lines;
        }

        var half = lines.Count() / 2 + lines.Count() % 2;
        var count = lines.Select(l => int.Parse($"{l[currentPos]}")).Sum();

        var bit = (count < half) ? '0' : '1';
        return OxygenGenerator(lines.Where(line => line[currentPos] == bit).ToArray(), binairyLength, ++currentPos);
    }

    private IEnumerable<string> CO2Scrubber(IEnumerable<string> lines, int binairyLength, int currentPos)
    {
        if (currentPos == binairyLength || lines.Count() == 1)
        {
            return lines;
        }

        var half = lines.Count() / 2 + lines.Count() % 2;
        var count = lines.Select(l => int.Parse($"{l[currentPos]}")).Sum();

        var bit = (count < half) ? '0' : '1';
        return CO2Scrubber(lines.Where(line => line[currentPos] != bit).ToArray(), binairyLength, ++currentPos);
    }


}

