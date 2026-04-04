using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) :base(name, description, duration)
    {
        
    }
    public void Run()
    {
        Console.Clear();
        Console.Write("Get ready");
        DotAnimation(3);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length());

        while (DateTime.Now < futureTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(3);

            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine("");
        }

        

    }
}