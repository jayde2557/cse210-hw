using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        List<int> numbers =  new List<int>();
        

        while(number !=0)
        {
            numbers.Add(number);

            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
        }

        int total = 0;
        int largestNumber = 0;

        for (int i = 0; i <numbers.Count; i++)
        {
            total += numbers[i];
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }

        float average = (float)total / numbers.Count;
        Console.WriteLine($"Sum: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largestNumber}");

        
        numbers.Sort();

        Console.WriteLine("\nSorted list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        

    }
}