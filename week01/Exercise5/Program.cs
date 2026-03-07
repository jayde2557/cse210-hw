using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SquareNumber(number);
        DisplayResult(name, squaredNum);


        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string output = Console.ReadLine();
            int number = int.Parse(output);
            return number;
        }

        static int SquareNumber(int num)
        {
            int squareNum = num * num;
            return squareNum;
        }

        static void DisplayResult(string userName, int sqNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqNum}.");
        }
    }
}