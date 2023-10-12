using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userNumber;
        int number;
        int sum = 0;
        int max = -999999999;
        int smallPositive = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do 
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbers.Add(number);
                if (number > max)
                {
                    max = number;
                }

                if (number > 0)
                {
                    smallPositive = number;
                }
            }

        } while (number != 0);

        foreach (int n in numbers)
        {
            sum += n;
        }

        numbers.Sort();

        float newSum = Convert.ToSingle(sum);

        float average = newSum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallPositive}");
        Console.WriteLine($"The sorted list is:");

        foreach (int sortNumber in numbers)
        {
            Console.WriteLine(sortNumber);
        }
    }
}