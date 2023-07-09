using System;
using System.Linq;
using System.Collections.Generic;

class Customer
{
    string _name;
    Address _customerAddress = new Address();

    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _customerAddress;
    }
    public string FindUSA()
    {
        if (_customerAddress.GetCountry() is "USA")
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }
}