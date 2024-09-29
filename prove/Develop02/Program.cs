using System;
class Program
{
    static void Main(string[] args)
    {   bool running = true;
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
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                PromptGenerator prompt = new PromptGenerator();
                prompt.GetRandomPrompt();
                string entry = Console.ReadLine();

                Entry entry1 = new Entry();
                entry1._date = dateText;
                entry1._promtText = prompt.GetRandomPrompt();
                entry1._entryText = entry;
                entry1.Display();
            }
            else if (choice == "2")
            {
                Console.WriteLine("ESTE ES OPCION 3333");
            }
            else if (choice == "3")
            {
                Console.WriteLine("ESTE ES OPCION 3333");
            }
            else if (choice == "4")
            {
                Console.WriteLine("ESTE ES OPCION 4444");
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