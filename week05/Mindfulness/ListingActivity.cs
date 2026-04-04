using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    public ListingActivity(string name, string description, int duration) :base(name, description, duration)
    {
        
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("Get ready");
        DotAnimation(3);
        Console.WriteLine("");
        ShowSpinner(1);

        Random random = new Random();
        int num = random.Next(_prompts.Count);
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[num]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        
        DateTime endTime = DateTime.Now.AddSeconds(length());
        List<string> userResponses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items!");
    }

}