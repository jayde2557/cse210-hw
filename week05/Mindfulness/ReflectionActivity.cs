using System;
using System.Collections.Generic;
public class ReflectionActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"];

    public ReflectionActivity(string name, string description, int duration) :base(name, description, duration)
    {
        
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("Get ready");
        DotAnimation(2);
        Console.WriteLine("");

        ShowSpinner(1);


        Random random = new Random();
        int num = random.Next(_prompts.Count);
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[num]} ---");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        Console.Clear();

        List<string> remainingQuestions = new List<string>(_questions);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length());

        while (DateTime.Now < endTime && remainingQuestions.Count > 0)
        {
            int index = random.Next(remainingQuestions.Count);
            string question = remainingQuestions[index];
            Console.Write($"\n> {question} ");
            remainingQuestions.RemoveAt(index);
            ShowSpinner(8);
        }

    }


}