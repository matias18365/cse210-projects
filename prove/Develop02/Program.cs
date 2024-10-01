using System;
class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        bool running = true;
        while (running)
        {   
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry1 = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry1._date = dateText;
                PromptGenerator prompt = new PromptGenerator();
                entry1._promptText = prompt.GetRandomPrompt();
                string entry = Console.ReadLine();
                entry1._entryText = entry;
                journal.AddEntry(entry1);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the name of the file you would like to load? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the name of the file to save to? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting from the journal program");
                running = false; //this will stop the loop
            }
            else
            {
                Console.WriteLine("Invalid choice, please enter a number between 1 and 5.");
            }
        }
    }
}