using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

class Breathing : Activity
{

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
    public void BreathingActivity()
    {
        
    }
}