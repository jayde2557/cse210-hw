using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double productTotal = 0;

        foreach (Product p in _products)
        {
            productTotal += p.totalCost();
        }

        double shipping;

        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return productTotal + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetID()})\n";
        }

        return label;
    }
    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}