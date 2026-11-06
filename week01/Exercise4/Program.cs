using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int largest = numbers[0];
            int smallestPositive = int.MaxValue;

            foreach (int item in numbers)
            {
                sum += item;

                if (item > largest)
                {
                    largest = item;
                }

                if (item > 0 && item < smallestPositive)
                {
                    smallestPositive = item;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");

            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}