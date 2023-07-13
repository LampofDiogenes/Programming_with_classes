using System;
using System.Linq;
using System.Collections.Generic;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public Event()
    {

    }
    private void EventType()
    {
        _eventType = "Generic";
    }

    protected string StandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    protected string FullDetails()
    {
        // Needs to be created after all classes are completed
        return "";
    }
    protected string ShortDescription()
    {
        // Needs to be created after all classes are completed
        return "";
    }
}