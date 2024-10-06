using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = GetRandomScripture();
        bool running = true;

        while (running)
        {   
            Console.Clear(); //This will clear the console
            Console.WriteLine(scripture.GetDisplayText() + "\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string choice = Console.ReadLine();

            if (choice == "")
            {
                scripture.HideRanbomWords(3); //Hide 3 words
                if (scripture.IsCompletelyHidden())
                {   
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText() + "\n");
                    running = false;
                }
            }
            else if (choice == "quit")
            {
                running = false; //this will finish the program
            }
            else
            {
                Console.WriteLine("Invalid input, please press enter or type 'quit' to finish");
            }
        }
    }

    static Scripture GetRandomScripture()
    {
        Random rand = new Random();
        int selection = rand.Next(3); //Randomly select one of the scriptures

        if (selection == 0)
        {
            Reference reference = new Reference ("John", 3, 16);
            string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            return new Scripture(reference, text);
        }
        else if (selection == 1)
        {
            Reference reference = new Reference("Mosiah", 2, 17);
            string text = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
            return new Scripture(reference, text);
        }
        else 
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            return new Scripture(reference, text);
        }
    }
}