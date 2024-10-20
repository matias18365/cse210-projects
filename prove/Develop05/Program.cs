using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    var reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    var listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    continue;
            }
        }
    }
}