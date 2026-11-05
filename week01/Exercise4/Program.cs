using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to quit.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                return;
            }

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        long sum = 0;
        int largest = numbers[0];
        int? smallestPositive = null;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }

            if (number > 0 && (!smallestPositive.HasValue || number < smallestPositive.Value))
            {
                smallestPositive = number;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}