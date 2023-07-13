using System;
using System.Linq;
using System.Collections.Generic;

class Order
{
    Customer _customer;
    List<Product> _productList = new List<Product>();
    List<string> _packingLabel = new List<string>();
    List<string> _shippingLabel = new List<string>();
    int _totalPrice;
    int _shippingPrice;

    public Order(Customer customer, List<Product> productlist)
    {
        _customer = customer;
        _productList = productlist;
    }
    public int CalculateTotal()
    {
        _totalPrice = 0;
        foreach (Product product in _productList)
        {
            _totalPrice += product.ItemTotal();
        }
        return _totalPrice;
    }
    public int ShippingCost()
    {
        if (_customer.FindUSA() is "USA")
        {
            _shippingPrice = 5;
        }
        else
        {
            _shippingPrice =  35;
        }
        return _shippingPrice;
    }

    public List<string> CreatePackingLabel()
    {
        foreach (Product product in _productList)
        {
            _packingLabel.Add(product.GetName() + ", " + product.GetID());
        }
        return _packingLabel;
    }

    public string CreateShippingLabel()
    {
        return _customer.GetName() + ", " + _customer.GetAddress();
    }
    public int TotalCost()
    {
        return _totalPrice + _shippingPrice;
    }

}