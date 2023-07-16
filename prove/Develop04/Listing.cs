using System;
using System.Linq;
using System.Collections.Generic;

class Listing : Activity
{


    public override void DefaultActivityName()
    {
        _activityName = "Listing";
    }
    public override void DefaultActivityDescription()
    {
        _activityDescription = @"This is an activity to list as many strengths 
        in an area as you can in a specific time.";
    }
}