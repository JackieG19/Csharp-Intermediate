/*
- Inside the get/set methods we can have some logic.

- If you don’t need to write any specific logic in the get or set method, 
  it’s more efficient to create an auto-implemented property. 
  
An auto-implemented property encapsulates a private field behind the scene. 

So you don’t need to manually create one.

The compiler creates one for you:*/

public class Customer
{
    public string Name { get; set; }
}