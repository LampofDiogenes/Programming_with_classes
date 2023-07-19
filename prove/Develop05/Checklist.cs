using System;

class Checklist : Goal
{
    private int _finishLine;
    public override void GoalCompleted()
    {
        _timesCompleted += 1;
    }
    public void SetFinishLine(int goalFinished)
    {
        _finishLine = goalFinished;
    }
    public int GetFinishLine()
    {
        return _finishLine;
    }
    public override int PointsRecieved()
    {
        if (_timesCompleted >= _finishLine)
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
        return $"[{_timesCompleted} / {_finishLine}]";
    }
}