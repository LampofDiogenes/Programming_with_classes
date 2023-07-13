using System;
using System.Linq;
using System.Collections.Generic;

class Lecture : Event
{
    protected string _speaker;
    protected string _maxCapacity;

    public Lecture(string title, string speaker, string description, string limit,
    string date, string time, Address address): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = limit;
    }
    public override string EventType()
    {
        _eventType = "Lecture";
        return _eventType;
    }
    public override string FullDetails()
    {
        return $"{_title}, {_speaker}, {_eventType}, {_description}, {_maxCapacity}, {_date}, {_time}, {_address}";
    }

}