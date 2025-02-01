using System;

public class Order
{
    // Private fields
    private List<Product> _products;
    private Customer _customer;

    // Public properties
    public List<Product> Products
    {
        get => _products;
        private set => _products = value;
    }

    public Customer Customer
    {
        get => _customer;
        private set => _customer = value;
    }

    // Constructor for Order initialization
    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product), "Product cannot be null");
        _products.Add(product);
    }

    // Method to get the total price of the order, including shipping
    public decimal GetTotalPrice()
    {
        decimal productsTotal = _products.Sum(p => p.GetTotalCost());
        decimal shippingCost = Customer.IsInUSA() ? 5m : 35m;
        return productsTotal + shippingCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        var packingLabel = new System.Text.StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return packingLabel.ToString();
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        var shippingLabel = new System.Text.StringBuilder();
        shippingLabel.AppendLine(Customer.Name);
        shippingLabel.AppendLine(Customer.CustomerAddress.GetFullAddress());
        return shippingLabel.ToString();
    }
}
