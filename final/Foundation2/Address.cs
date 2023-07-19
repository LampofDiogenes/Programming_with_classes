using System;
using System.Linq;
using System.Collections.Generic;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreet()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }

    public string FullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }


    public string FindUSA()
    {
        if (_country is "USA")
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }
}