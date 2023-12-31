using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string userName = PromptUserName();
       int userNumber = PromptUserNumber();
       int squareNumber = SquareNumber(userNumber);
       DisplayResult(userName, squareNumber);
       
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string enteredNumber = Console.ReadLine();
        int userNumber = int.Parse(enteredNumber);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;

    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}