// Constructors
/* - a method that is called when an instance of a class is created.
- use to put an object in an early state.
- define only when an object “needs” to be initialised or it won’t be able to do its job.
- do not have a return type, not even void, and they should have the exact same name as the class.
- A quick way to create: type ctor and press tab. This is a code snippet.
- can be overloaded. Overloading means creating a method with the same name and different signatures.
- Signature of a method consists of the number, type and order of its parameters.
- can pass control from one constructor to the other by using the this keyword.*/

public class Customer
{

    public int Id;
    public string Name;
    public List<Order> Orders;

    // Default or parameterless constructor public Customer()
    public Customer()
    {
    // Orders has to be initialized here, otherwise it
    // will be a null reference. As a best practice,
    // anytime your class contains a list, always
    // initialize the list.
    Orders = new List<Order>();
    }

    public Customer(int id)
    : this() // Calls the default constructor
    {
    this.Id = id;
    }
}

