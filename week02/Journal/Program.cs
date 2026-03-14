//I added a searxh method to the journal class to exceed requirements

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int menuOption = 0;

        while (menuOption != 6)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit\n");

            Console.Write("Choose an option: ");
            menuOption = int.Parse(Console.ReadLine());

        if(menuOption == 1)
            {
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);

            }

        else if (menuOption == 2)
            {
                journal.DisplayAll();
            }

        else if (menuOption == 3)
        {
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            journal.SaveToFile(file);
        }

        else if (menuOption == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully:\n");
                journal.DisplayAll();
            }

        else if (menuOption == 5)
            {
                Console.Write("Enter keyword to search: ");
                string keyword = Console.ReadLine();

                journal.SearchEntries(keyword);

            }
        }
    }
}