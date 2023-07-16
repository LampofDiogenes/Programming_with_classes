using System;
using System.Linq;
using System.Collections.Generic;

class Activity
{
    protected string _activityName;
    protected string _activityDescription;

    public Activity()
    {
        DefaultActivityName();
        DefaultActivityDescription();
    }
    public virtual void DefaultActivityName()
    {
        _activityName = "Generic";
    }
    public virtual void DefaultActivityDescription()
    {
        _activityDescription = "Just a general activity. No specific things happening";
    }
}