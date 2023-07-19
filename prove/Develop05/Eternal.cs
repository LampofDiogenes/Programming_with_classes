using System;

class Eternal : Goal
{
    public override void GoalCompleted()
    {
        _timesCompleted += 1;
    }
    public override int PointsRecieved()
    {
        
        return _pointValue;
    }
    public override string ShowCompletion()
    {
        return "[Keep Going!]";
    }
}