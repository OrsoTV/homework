using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 3, 8, 20, 1, 15 };

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        Console.WriteLine("Минимальное число: " + min);
        Console.WriteLine("Максимальное число: " + max);
    }
}
