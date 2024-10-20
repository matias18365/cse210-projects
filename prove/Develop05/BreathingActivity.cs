using System;
using System.Collections;
using System.Collections.Generic;
class BreathingActivity : Activity

{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        System.DateTime endTime = System.DateTime.Now.AddSeconds(duration);

        while (System.DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}
