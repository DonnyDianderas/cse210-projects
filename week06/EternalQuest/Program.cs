// This program allows the user to create, list, save, load, and record events 
// for different types of goals: Simple, Eternal, and Checklist.
// Points are accumulated based on goal events.
//I have added the option "Clears the current goals and resets the score" so that 
// the user can load their new goals and achievements into different txt files without overwriting a previous one.


using System;


class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

