/*
- Signature of a method consists of the number, type and order of its parameters.
- Overloading a method means having a method with the same name but with different signatures.
  This makes it easier for the callers of the method to choose the more suitable signature
  depending on the type of data they have to pass to the method.*/

public class Point
{
    public void Move(int x, int y)
    {
        ...
    }

    // The Move method overloaded here
    public void Move(Point newLocation)
    {
        ...
    }
}
