using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Start visualization Exercise");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "5")
                break;

            Activity activity = null;
            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectingActivity();
            else if (choice == "3")
                activity = new ListingActivity();
            else if (choice == "4")
                activity = new VisualizationActivity();

            if (activity != null)
            {
                activity.Start();
            }
        }
    }
}