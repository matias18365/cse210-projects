using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn from this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on personal experiences where you showed strength. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        System.DateTime endTime = System.DateTime.Now.AddSeconds(GetDuration());
        while (System.DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }
        
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)]; 
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)]; 
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}