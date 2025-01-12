using System;

class Program
{
    static void Main(string[] args)
    {
       GreetUser();

        // Prompt the user for their name and favorite number
        string personName = AskForName();
        int favoriteNumber = AskForFavoriteNumber();

        // Calculate the square of the number
        int squaredValue = CalculateSquare(favoriteNumber);

        // Display the result
        ShowResult(personName, squaredValue);
    } 

    static void GreetUser()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string AskForName()
    {
        Console.Write("Please enter your name? ");
        return Console.ReadLine();
    }

    static int AskForFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int CalculateSquare(int num)
    {
        return num * num;
    }

    static void ShowResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}.");
    }

}