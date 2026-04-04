//Creativity
//1 - temporary list in ReflectionActivity to make sure that reflection questions are never repeated within a single session
//2-added dot animation in the base class 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int menuOption = 0;
        while (menuOption!= 4)
        {
            Console.WriteLine("Welcome to the Mindfulness Program\nMenu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

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

            else if (menuOption == 2)
            {
                ReflectionActivity activity1 = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0
                );

                activity1.DisplayStartingMessage();
                activity1.Run();
                activity1.DisplayEndingMessage();
            }

            else if (menuOption == 3)
            {
                ListingActivity activity2 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0
                );

                activity2.DisplayStartingMessage();
                activity2.Run();
                activity2.DisplayEndingMessage();
            }

        }
        
        
        

    }
}