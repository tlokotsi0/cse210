public class Customer
{
    // Private fields
    private string _name;
    private Address _address;

    // Public properties
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

    public Address CustomerAddress
    {
        get => _address;
        set
        {
            if (value == null) 
                throw new ArgumentException("Address cannot be null");
            _address = value;
        }
    }

    // Constructor for Customer initialization
    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}
