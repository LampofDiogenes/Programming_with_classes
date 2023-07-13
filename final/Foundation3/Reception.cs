using System;
using System.Linq;
using System.Collections.Generic;

class Reception : Event
{
    protected List<string> _registeredPeople = new List<string>();
    protected string _registeredString;

    public Reception(string title, string description, List<string> registeredPeople,
    string date, string time, Address address): base(title, description, date, time, address)
    {
        List<string> _registeredPeople = registeredPeople;
    }
    public override string EventType()
    {
        _eventType = "Reception";
        return _eventType;
    }

    ///// There is not reason why this should not work, but it fails to do so. WHY?!?!?!?!
    public override string FullDetails()
    {
        CombineList();

        _registeredString = $"{_title}, {_eventType}, {_description},";

        foreach (string person in _registeredPeople)
        {
            _registeredString += $"{person}, ";
        }
        _registeredString += $"{_title}, {_eventType}";
        return _registeredString;
    }
    public void CombineList()
    {
        foreach (string person in _registeredPeople)
        {
            _registeredString += $"{person}, ";
        }
    }
}