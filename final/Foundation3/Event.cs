using System;
using System.Linq;
using System.Collections.Generic;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    protected string _RSVPemail;

    public void SetEmail(string email)
    {
        _RSVPemail = email;
    }   
    public string GetEmail()
    {
        return _RSVPemail;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetEventType()
    {
        return _eventType;
    }

    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.FullAddress();
    }
    public Event()
    {

    }
    public virtual string EventType()
    {
        _eventType = "Generic";
        return _eventType;
    }

    public string StandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public virtual string FullDetails()
    {
        // Needs to be created after all classes are completed
        return $"{_title}, {_eventType}, {_description}, {_date}, {_time}, {_address}";
    }
    public string ShortDescription()
    {
        // Needs to be created after all classes are completed
        return $"{_eventType}, {_title}, {_date}";
    }
}