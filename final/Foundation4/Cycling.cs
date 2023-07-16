using System;
using System.Linq;
using System.Collections.Generic;

class Cycling : Activity
{
    // the user inputs time and speed

    public override void FindDistance()
    {
        _kilometerDistance = _speed * (float)_minutesTaken;
    }
    public override string MakeSummary()
    {
        return $"{_date}, Cycling ({_minutesTaken} minutes): Distance: {_kilometerDistance} km, Speed: {_speed} km / hr, Pace: {_pace} min /km)";
    }
}