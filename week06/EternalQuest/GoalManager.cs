using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type? ");
        string type = Console.ReadLine();

        Console.Write("Whst is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Write a short description of it: ");
        string description = Console.ReadLine();

        Console.Write("How many points for this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target amount: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");

        int count = 1;
        foreach (Goal g in _goals)
        {
            string status;
            if (g.IsComplete())
            {
                status = "[X]";
            }
            else
            {
                status = "[ ]";
            }
            Console.WriteLine($"{count}. {status} {g.GetDetailsString()}");
            count++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Choose: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int gained = _goals[index].RecordEvent();
        _score += gained;

        Console.WriteLine($"You earned {gained} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) {
                });
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[5]), int.Parse(parts[6])
                );

                cg.SetProgress(int.Parse(parts[4]));
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Loaded!");
    }
}