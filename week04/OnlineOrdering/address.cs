public class Address
{
    // Private fields
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Public properties
    public string Street
    {
        get => _street;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Street cannot be empty");
            _street = value;
        }
    }

    public string City
    {
        get => _city;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("City cannot be empty");
            _city = value;
        }
    }

    public string State
    {
        get => _state;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("State cannot be empty");
            _state = value;
        }
    }

    public string Country
    {
        get => _country;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Country cannot be empty");
            _country = value;
        }
    }

    // Constructor for Address initialization
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}
