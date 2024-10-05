using System;

class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        Console.WriteLine($"this is a constructor");
    }


    private void Hide()
    {
        Console.WriteLine($"this is a behavior");
    }
    private void Show()
    {
        Console.WriteLine($"this is a behavior");
    }
    private bool IsHidden()
    {
        Console.WriteLine($"this is a behavior")
    }
    private string GetDisplayText()
    {
        Console.WriteLine($"this is a behavior");
    }
}
