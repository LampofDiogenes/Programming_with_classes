using System;
using System.Linq;
using System.Collections.Generic;

class Activity
{
    protected float _kilometerDistance;
    protected float _speed;
    protected double _pace;
    protected int _minutesTaken;
    protected string _date;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        return _speed;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }

    public void SetDistance(int distance)
    {
        _kilometerDistance = distance;
    }
    public float GetDistance()
    {
        return _kilometerDistance;
    }
    public void SetTime(int time)
    {
        _minutesTaken = time;
    }
    public int GetTime()
    {
        return _minutesTaken;
    }

    public virtual void FindSpeed()
    {
        _speed = (_kilometerDistance / _minutesTaken) * 60;
        
    }
    public virtual double FindPace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
    public virtual void FindDistance()
    {
        
    }
    public virtual string MakeSummary()
    {
        return $"{_date}, Generic Activity ({_minutesTaken} minutes): Distance: {_kilometerDistance} km, Speed: {_speed} km / hr, Pace: {_pace} min /km)";
    }
}