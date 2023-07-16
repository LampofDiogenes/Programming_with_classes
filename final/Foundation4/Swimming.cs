using System;
using System.Linq;
using System.Collections.Generic;

class Swimming : Activity
{
    // the user inputs time and laps
    protected int _laps;

    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public override void FindDistance()
    {
        _kilometerDistance = (float)_laps * (50f / 1000);
    }


        public override string MakeSummary()
    {
        return $"{_date}, Swimming ({_minutesTaken} minutes): Distance: {_kilometerDistance} km, Speed: {_speed} km / hr, Pace: {_pace} min /km)";
    }
}