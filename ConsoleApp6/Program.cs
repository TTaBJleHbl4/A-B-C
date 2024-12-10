using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\fl.txt";
        string inputString;

        try
        {
           
            inputString = File.ReadAllText(filePath).Trim();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
            return;
        }

        int maxPairs = FindMaxPairs(inputString);

        Console.WriteLine($"Максимальное количество подряд идущих пар: {maxPairs}");
    }

    static int FindMaxPairs(string input)
    {
        int maxPairs = 0;
        int currentCount = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if ((input[i] == 'A' && input[i + 1] == 'B') || (input[i] == 'C' && input[i + 1] == 'B'))
            {
                currentCount++;
                i++; 
            }
            else
            {
                maxPairs = Math.Max(maxPairs, currentCount);
                currentCount = 0;
            }
        }

        maxPairs = Math.Max(maxPairs, currentCount);

        return maxPairs;
    }
}
