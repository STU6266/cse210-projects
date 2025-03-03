using System;

class Program
{
    static void Main(string[] args)
    {
     WelcomeMessage();

        string userName = AskUserName();

        int userNumber = AskUserNumber();

        int squaredNumber = Square(userNumber);

        Result(userName, squaredNumber);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static string AskUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }


    static int Square(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}