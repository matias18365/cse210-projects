using System;

class Reference
{
    static void Main(string[] args)
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        Console.WriteLine($"this is a constructor");
    }
    public Reference(string book, int chapter, int startVerse, int _endVerse)
    {
        Console.WriteLine($"this is a constructor");
    }


    private string GetDisplayText()
    {
        Console.WriteLine($"this is a behavior");
    }
}