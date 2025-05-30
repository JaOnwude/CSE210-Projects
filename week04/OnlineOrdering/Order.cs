using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
