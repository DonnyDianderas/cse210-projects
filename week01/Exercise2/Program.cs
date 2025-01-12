//This program asks the user for their grade percentage, then calculates and displays the corresponding letter grade (A, B, C, D, or F)
//This program add a + or - sign based on the last digit of the percentage (except for F and A+ grades). 
//This program informs the user whether they passed the course (70% or higher) or need to try again.

using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("Tell me your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }

        if (percentage >= 70)
        {
            Console.WriteLine("You pass the course.");
        }
        else
        {
            Console.WriteLine("You don't pass. Try your best next time!.");
        }*/
        
        Console.Write("Tell me your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int lastDigit = percentage % 10; // to get the last digit of the percentage
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letter == "A" && sign == "+")
        {
            sign = ""; // to remove the "+" for A+
        }
        else if (letter == "F")
        {
            sign = ""; // because F grades have not a "+" or "-"
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You pass the course.");
        }
        else
        {
            Console.WriteLine("You don't pass. Try your best next time!.");
        }
    }
}