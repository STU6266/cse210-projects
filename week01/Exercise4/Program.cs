using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                number.Add(userNumber);
            }
        }
            int sum = 0;
            foreach (int num in number)
        {
            sum += num;
        }
            Console.WriteLine($"The sum of the numbers is: {sum}");

            float average = ((float)sum) / number.Count;
            Console.WriteLine($"The average is: {average}");

            int max = number[0];

            foreach (int num in number)
        {
                if (num > max)
            {
                // if this number is greater than the max, we have found the new max!
                    max = num;
            }
        }

            Console.WriteLine($"The max is: {max}");
        }
    }