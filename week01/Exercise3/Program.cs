using System;

class Program
{
    static void Main(string[] args)
    {
        /*First step:

        Console.Write("What is the magic number? ");
        int Number_magic = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int Number_guess = int.Parse(Console.ReadLine());

        if (Number_guess < Number_magic)
        {
            Console.WriteLine("Higher");
        }
        else if (Number_guess > Number_magic)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }*/

        //Step 2:

        /*Console.Write("What is the magic number? ");
        int Number_magic = int.Parse(Console.ReadLine());

        
        int Number_guess = -1; 
        while (Number_guess != Number_magic) 
        {
            
            Console.Write("What is your guess? ");
            Number_guess = int.Parse(Console.ReadLine());

           
            if (Number_guess < Number_magic)
            {
                Console.WriteLine("Higher");
            }
            else if (Number_guess > Number_magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }*/

        //Step 3:

        string playAgain = "yes"; 

        while (playAgain.ToLower() == "yes")
        {
            Random Numbergenerator = new Random();
            int Number_magic = Numbergenerator.Next(1, 101); 

            int Number_guess = -1;
            int attemptsCount = 0; 

            while (Number_guess != Number_magic)
            {
                Console.Write("What is your guess? ");
                Number_guess = int.Parse(Console.ReadLine());
                attemptsCount++; 

                if (Number_guess < Number_magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (Number_guess > Number_magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attemptsCount} guesses to find the magic number.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}