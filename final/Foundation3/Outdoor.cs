using System;
using System.Linq;
using System.Collections.Generic;

class Outdoor : Event
{
    protected string _forecast;

    public Outdoor(string title, string description,
    string date, string time, Address address, string forecast): base(title, description, date, time, address)
    {
        _forecast = forecast;
    }
    public override string EventType()
    {
        _eventType = "Outdoors";
        return _eventType;
    }

    public override string FullDetails()
    {
        return $"{_title}, {_eventType}, {_description}, {_date}, {_time}, {_address}, {_forecast}";
    }
}