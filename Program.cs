using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 15, 26, 112, 3333 };

        int min = numbers.Min();
        int max = numbers.Max();

        Console.WriteLine("Минимальное число: " + min);
        Console.WriteLine("Максимальное число: " + max);
    }
}