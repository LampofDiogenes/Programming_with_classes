using System;

class Simple : Goal
{
    public override void GoalCompleted()
    {
        base.GoalCompleted();
        PointsRecieved();
    }
    public override int PointsRecieved()
    {
        if (_timesCompleted is 1)
        {
            return _pointValue;
        }
        else
        {
            return 0;
        }   
    }
    public override string ShowCompletion()
    {
        if (_timesCompleted is 1)
        {
         return $"[Completed]";   
        }
        else
        {
            return "[Incomplete]";
        }
        
    }
}
