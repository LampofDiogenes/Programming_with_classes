using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

class Breathing : Activity
{
    int _countdown = 6;

    public override void DefaultActivityName()
    {
        _activityName = "Breathing";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = @"This is an activity to focus on controlling breathing.
In this activity, we will guide you through breathing in and out. Clear your mind, and focus on 
breathing.";
    }
    public void BreathingIn()
    {
        while (_countdown is not 0)
        {
        Console.WriteLine($"Breathe in ...{_countdown}");
        Thread.Sleep(1000);
        Console.Clear();
        _countdown -= 1;
        }
    }
    public void BreathingOut()
    {
        while (_countdown is not 0)
        {
        Console.WriteLine($"Breathe out ...{_countdown}");
        Thread.Sleep(1000);
        Console.Clear();
        _countdown -= 1;
        }
    }

    public void BreathingExcersize(int _activityDuration)
    {
        int _timeTaken = 0;
        while (_timeTaken <= _activityDuration)
        {
            BreathingIn();
            _countdown = 6;
            _timeTaken += 6;
            BreathingOut();
            _countdown = 6;
            _timeTaken += 6;
        }
    }
}