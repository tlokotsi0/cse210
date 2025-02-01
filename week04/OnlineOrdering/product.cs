public class Product
{
    // Private fields
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Public properties with getters and setters for encapsulation
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) 
                throw new ArgumentException("Name cannot be empty");
            _name = value;
        }
    }

    public string ProductId
    {
        get => _productId;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Product ID cannot be empty");
            _productId = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value <= 0) 
                throw new ArgumentException("Price must be greater than zero");
            _price = value;
        }
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantity cannot be negative");
            _quantity = value;
        }
    }

    // Constructor for Product initialization
    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    // Method to calculate the total cost of this product
    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }
}
