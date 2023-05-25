using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.

    static void mainFunction()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        
        int favoriteNumber = PromptUserNumber();

        int number = SquareNumber(favoriteNumber);

        DisplayResult(userName, number);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your username? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favoriteNumber = Console.ReadLine();
        int favNumber = int.Parse(favoriteNumber);
        return favNumber;
    }

    static int SquareNumber(int userInteger)
    {
        int squared = userInteger * userInteger;
        return squared;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"This is your user name; {userName}.");
        Console.WriteLine($"This is your squared number: {squaredNumber}.");
    }

    mainFunction();
    }
}