using System;
using System.Linq;
using System.Collections.Generic;

class Breathing : Activity
{

    public override void DefaultActivityName()
    {
        _activityName = "Breathing";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = "This is an activity to focus on controlling breathing";
    }
}