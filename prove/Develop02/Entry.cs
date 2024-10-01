using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _feeling;

    public void Display()
    {
        Console.WriteLine($"");
        Console.WriteLine($"Date: {_date} | Prompt: {_promptText}");
        Console.WriteLine($"{_entryText} and I felt {_feeling}");
    }
}