using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        Console.WriteLine($"this is a constructor");
    }

    private void HideRanbomWords(int numberToHide)
    {
        Console.WriteLine($"this is a behavior");
    }
    private string GetDisplayText()
    {
        Console.WriteLine($"this is a behavior");
        return "";  // Add appropriate string return value
    }
    private bool IsCompletelyHidden()
    {
        Console.WriteLine($"this is a behavior");
        return false; // Add appropriate boolean return value
    }
}
