using System;

class Scripture
{
    static void Main(string[] args)
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        Console.WriteLine($"this is a constructor");
    }

    private void HideRambomWords(int numberToHide)
    {
        Console.WriteLine($"this is a behavior");
    }
    private string GetDisplayText()
    {
        Console.WriteLine($"this is a behavior");
    }
    private bool IsCompletelyHidden()
    {
        Console.WriteLine($"this is a behavior")
    }
}
