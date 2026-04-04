using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}");
        Console.Write($"How long, in seconds, would you like for your seesion? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public int length()
    {
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250); 
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; 
            }
        }
    }

    public void DisplayEndingMessage()
    {
        Console.Write($"\nWell done!");
        ShowSpinner(2);
        Console.WriteLine("");
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
    }

    public void ShowCountDown(int seconds)
    {
        
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DotAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(500);

        }
    }
}