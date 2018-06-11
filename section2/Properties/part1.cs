/*
- A property is a kind of class member that is used for providing access to fields of a class.

- As a best practice, we must declare fields as private and create public properties to provide access to them.

- A property encapsulates a get and a set method:*/

public class Customer
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
