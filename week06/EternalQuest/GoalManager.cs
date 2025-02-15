using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
   
    private string _currentFile = "";

    public int GetAccumulatedPoints() => _score;

    public void Start()
    {
        string menuSelected = "";
        while (menuSelected != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("  7. Clear Current Goals");
            Console.Write("Select a choice from the menu: ");
            menuSelected = Console.ReadLine();
            Console.WriteLine();

            switch (menuSelected)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                case "7":
                    ClearGoals();
                    break;
                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo() => Console.WriteLine($"You have {_score} points.");

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal g in _goals)
        {
            Console.Write($"{count}. ");
            Console.WriteLine(g.GetDetailsString());
            count++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal newEternalGoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("Enter the target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newChecklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        string input = Console.ReadLine();
        int index = int.Parse(input) - 1;
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[index];

        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                Console.WriteLine("The goal has already been achieved.");
                return;
            }
            else
            {
                if (checklist.AmountCompleted == checklist.Target - 1)
                {
                    checklist.RecordEvent(); 
                    int pointsEarned = checklist.Points + checklist.Bonus;
                    _score += pointsEarned;
                    Console.WriteLine($"Congratulations, you have completed this goal and will receive {checklist.Bonus} bonus points.");
                    Console.WriteLine($"You now have {_score} points.");
                }
                else
                {
                    checklist.RecordEvent();
                    int pointsEarned = checklist.Points;
                    _score += pointsEarned;
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
            }
        }
        else
        {
            if (goal.IsComplete())
            {
                Console.WriteLine("The goal has already been achieved.");
            }
            else
            {
                goal.RecordEvent();
                int pointsEarned = goal.Points;
                _score += pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename to save your goals? ");
        string fileName = Console.ReadLine();

        if (!string.IsNullOrEmpty(_currentFile) && fileName != _currentFile)
        {
            Console.WriteLine($"Warning: You are currently working with the file \"{_currentFile}\" loaded from a previous session.");
            Console.Write("Do you want to save to the current file instead? (Y/N): ");
            string response = Console.ReadLine();
            if (response.ToUpper() == "Y")
            {
                fileName = _currentFile;
            }
            else
            {
                Console.WriteLine("Save cancelled. Please use the file currently loaded.");
                return;
            }
        }

        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to " + fileName + ".");
        _currentFile = fileName;
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename to load your goals? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length == 0)
            {
                Console.WriteLine("The file is empty.");
                return;
            }

            _score = int.Parse(lines[0]);
            _goals.Clear();

            if (lines.Length > 1)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    string goalType = parts[0];
                    if (goalType == "SimpleGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool isComplete = bool.Parse(parts[4]);
                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                    }
                }
                Console.WriteLine("Goals loaded from " + fileName + ".");
                _currentFile = fileName;
            }
            else
            {
                Console.WriteLine("No goals found in the file.");
            }
        }
        else
        {
            Console.WriteLine("File not found: " + fileName + ".");
        }
    }

    public void ClearGoals()
    {
        _goals.Clear();
        _score = 0;
        _currentFile = "";
        Console.WriteLine("Current goals and score have been cleared.");
    }
}
