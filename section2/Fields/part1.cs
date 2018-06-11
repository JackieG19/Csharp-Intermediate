/*
A field can be initialized in two ways:

- In a constructor, or directly upon declaration.

- The benefit of initialising a field during declaration is that if your class has one or
more constructors, you’ll make sure that the field will always be initialised irrespective
of which constructor is going to be called.*/

public class Customer
{
    public List<Order> Orders = new List<Order>();
}
