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
            Console.WriteLine(scripture.GetDisplayText());
            string choice = Console.ReadLine();

            if (choice == "")
            {
                scripture.HideRanbomWords(1); //Hide 3 words
                if (scripture.IsCompletelyHidden())
                {
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
        int selection = rand.Next(2); //Randmly select one of the scriptures

        if(selection == 0)
        {
            Reference reference = new Reference ("John", 3, 16);
            string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
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