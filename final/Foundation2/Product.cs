using System;
using System.Linq;
using System.Collections.Generic;

class Product
{
    string _productName;
    string _productID;
    int _price;
    int _quantity;

    public Product(string name, string ID, int price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public void SetName(string productName)
    {
        _productName = productName;
    }
    public void SetID(string ID)
    {
        _productID = ID;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public string GetName()
    {
        return _productName;
    }
    public string GetID()
    {
        return _productID;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public int ItemTotal()
    {
        return _price * _quantity;
    }
}