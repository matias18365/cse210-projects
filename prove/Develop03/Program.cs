using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, scriptureText);
        bool running = true;

        while (running)
        {   
            Console.Clear(); //This will clear the console
            Console.WriteLine(scripture.GetDisplayText());
            string choice = Console.ReadLine();

            if (choice == "")
            {
                scripture.HideRanbomWords(3); //Hide 3 words
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
}