using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Welcome to the Mindfulness Program\nMenu Options");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        int menuOption = 0;
        Console.Write("Select an option: ");
        string option = Console.ReadLine();
        menuOption =int.Parse(option);

        if (menuOption == 1)
        {
            BreathingActivity activity = new BreathingActivity(
            "Breathing Activity",
            "This activity will help you calm your mind by guiding you through slow, relaxed breathing.",
            0   
             );

            activity.DisplayStartingMessage();

            activity.Run();

            activity.DisplayEndingMessage();
        }

        if (menuOption == 2)
        {
            ReflectionActivity activity1 = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0
            );

            activity1.DisplayStartingMessage();
            activity1.Run();
            activity1.DisplayEndingMessage();
        }

        if (menuOption == 3)
        {
            ListingActivity activity2 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0
            );

            activity2.DisplayStartingMessage();
            activity2.Run();
            activity2.DisplayEndingMessage();
        }

        if (menuOption == 4)
        {
            return;
        }

        
        




    }
}