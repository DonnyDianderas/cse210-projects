// This program displays a scripture, hides random words, and allows the user to reveal hidden words.
// The user can press "Enter" to hide words or type "reveal" to show previously hidden words.
// The program continues until all words are hidden or the user chooses to quit.

//"For the part 'Showing creativity and exceeding requirements,' I added the functionality to reveal the last words that were hidden, 
// to help the user verify if they said the exact words."

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("James", 1, 5, 6);
        string text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {   
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program will now end.");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue, type 'quit' to finish, or type 'reveal' to show hidden words:");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            if (input?.ToLower() == "reveal")
            {
                scripture.RevealRandomWords(3); // Show 3 words
            }
            else
            {
                scripture.HideRandomWords(3); // hidden 3 words
            }
        }
    }
}
