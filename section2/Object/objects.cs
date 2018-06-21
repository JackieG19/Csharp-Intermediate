public class Person
{
    public int Id;

    public string FirstName;

    public string LastName;

    public Datetime Birthday;

}


public class Person
{
    public Person(int id) {}

    public Person(int id, string firstName) {}

    public Person(int id, string firstName, string LastName) {}

    public Person(int id, Datetime birthday) {}

}


// Object Initializers

var person = new Person
{
    FirstName = "Mosh"
    LastName = "Hamedani"
}