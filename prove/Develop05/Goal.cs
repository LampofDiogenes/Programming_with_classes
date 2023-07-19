using System;

class Goal
{
    protected int _pointValue;
    protected int _timesCompleted = 0;
    public virtual void GoalCompleted()
    {
        _timesCompleted += 1;
    }
    // maybe have a "set goal" method to make it easier in the program?
    public void SetPointValue(int pointValue)
    {
        _pointValue = pointValue;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }
    public virtual int PointsRecieved()
    {
        return _pointValue;
    }
    public virtual string ShowCompletion()
    {
        return $"";
    }
    public virtual void SaveData(int UserScore)
    {

    }
    
}