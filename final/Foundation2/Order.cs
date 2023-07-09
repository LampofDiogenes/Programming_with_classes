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

    public Order(Customer customer, List<Product> productlist)
    {
        _customer = customer;
        _productList = productlist;
    }
    public int CartTotal()
    {
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
            return 5;
        }
        else
        {
            return 35;
        }
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

}