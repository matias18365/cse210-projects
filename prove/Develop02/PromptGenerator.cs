using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing that you are thankful for?",
        "What should you stop doing?",
        "What is the greatest blessing you have received today?",
        "Who made your day special and why?",
        "What did you learn from this day?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        return _prompts[index];
    }
}