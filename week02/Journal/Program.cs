// This program lets you write, view, save, and load journal entries with prompts.  
// Entries include the date, a question (prompt), and your response.  
// You can save entries to a file or load them back later.  
// As an additional requirement, I added a dictionary with a list of strings as a value.   
// The idea is that before "Write" the program sends me some suggestions to help me or focus on answering.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // I'm controlling the menu loop using a variable of type Bool.
        bool running = true;
        
        while (running)
        {
            // Display the menu:

            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Prompt: " + prompt);

                // Display example responses to help the user
                Console.WriteLine("\nHere are some ideas to help you start:");
                foreach (string suggestion in promptGenerator.GetSuggestions(prompt))
                {
                    Console.WriteLine("- " + suggestion);
                }

                Console.WriteLine("\nNow, it's your turn!");
                Console.Write("> ");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);}


            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");

                // this is to stop the loop

                running = false;
            }

            // If the user enters an invalid character, the program returns a warning message:

            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}
