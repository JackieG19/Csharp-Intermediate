// constructor overloading

public class Customer
{
    public Customer()
    {
        var customer = new Customer("John");
    }

    public string Name;

    public Customer(string name)
    {
        this.Name = name;
    }

    public Customer(int id, string name)
    {
        ...
    }
}