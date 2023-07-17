using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

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

    public string StartingMessage()
    {
        return $"The Activity is: {_activityName}. A Description is: {_activityDescription}";
    }

    public void PauseTime(int endTime)
    {  
        int flicker = 500;
        int duration = 0; // total time of animation
        while (duration < (endTime * 1000))
        {
            Console.Write("+");

            Thread.Sleep(flicker); // how quickly you want it to change between the two characters
            duration += flicker;

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(flicker);
            Console.Write("\b \b");
        }
    }
}