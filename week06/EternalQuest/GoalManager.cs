using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Goal newGoal;

        if (choice == "1")
        {
            newGoal = new SimpleGoal(shortName, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(shortName, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid input! Creating a SimpleGoal by default.");
            newGoal = new SimpleGoal(shortName, description, points);
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created! Press any key to continue...");
        Console.ReadKey();
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());
        if (index > 0 && index <= _goals.Count)
        {
           _score += int.Parse(_goals[index - 1].Points);
            Console.WriteLine("Congratulations! You have earned " + _goals[index - 1].Points + " points!");

            Console.WriteLine("You now have " + _score + " points!");
        }
        else
        {
            Console.WriteLine("Invalid selection! Press any key to continue...");
        }
        Console.ReadKey();
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = fileName ;
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved to " + filePath + "! Press any key to continue...");
        Console.ReadKey();
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = fileName;
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string scoreLine = sr.ReadLine();
                int.TryParse(scoreLine, out _score);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        Goal goal = DeserializeGoal(line);
                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                }
            }
            Console.WriteLine("Goals loaded from " + filePath + "! Press any key to continue...");
        }
        else
        {
            Console.WriteLine("No saved file found at " + filePath + "! Press any key to continue...");
        }
        Console.ReadKey();
    }

    private Goal DeserializeGoal(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length < 5) return null;
        string type = parts[0];
        string shortName = parts[1];
        string description = parts[2];
        string points = parts[3];
        if (type == "SimpleGoal")
        {
            bool isCompleted = bool.Parse(parts[4]);
            SimpleGoal sg = new SimpleGoal(shortName, description, points);
            if (isCompleted)
            {
                sg.RecordEvent();
            }
            return sg;
        }
        else if (type == "EternalGoal")
        {
            int eventCount = int.Parse(parts[4]);
            EternalGoal eg = new EternalGoal(shortName, description, points);
            for (int i = 0; i < eventCount; i++)
            {
                eg.RecordEvent();
            }
            return eg;
        }
        else if (type == "ChecklistGoal")
        {
            if (parts.Length < 7) return null;
            int amountCompleted = int.Parse(parts[4]);
            int target = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            ChecklistGoal cg = new ChecklistGoal(shortName, description, points, target, bonus);
            for (int i = 0; i < amountCompleted; i++)
            {
                cg.RecordEvent();
            }
            return cg;
        }
        return null;
    }
}
