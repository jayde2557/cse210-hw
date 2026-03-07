using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);

        string letter = "";
        string gradeType = "";

        int percent = grade % 10;

        if (percent >=7)
        {
            gradeType = "+";
        }
        else if (percent < 3)
        {
            gradeType = "-";
        }

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (letter == "F")
        {
           gradeType = ""; 
        }
        
        if (letter == "A" && gradeType == "+")
        {
           gradeType = ""; 
        }
        
        Console.WriteLine($"Your grade is: {letter}{gradeType}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed this course!");
        }

        else
        {
            Console.WriteLine("YOu didn't receive a passing grade. Better luck next time.");
        }

    }
}