using System;
using System.Linq;
using System.Collections.Generic;

class Running : Activity
{
    public override void FindSpeed()
    {
        _speed = _kilometerDistance / ((float)_minutesTaken / 60);
    }
    public override string MakeSummary()
    {
        return $"{_date}, Running ({_minutesTaken} minutes): Distance: {_kilometerDistance} km, Speed: {_speed} km / hr, Pace: {_pace} min /km)";
    }
}