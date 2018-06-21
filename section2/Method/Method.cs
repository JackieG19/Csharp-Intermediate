// Signature of a Method

//  Name

// Number and Type of parameters

public class Point
{
    public void Move(int x, int y)
    {
        ...
    }
}


// Overloading Methods

// having a method with the seame name but different signatures

public class Point
{
    public void Move(int x, int y) {}

    public void Move(Point newLocation) {}

    public void Move(Point newLocation, int speed) {}
}


// A method with varying number of parameters

public class Calculator
{
    public int Add(int n1, int n2) {}

    public int Add(int n1, int n2, int n3) {}

    public int Add(int n1, int n2, int n3) {}
}

public class Calculator
{
    public int Add(int [], numbers) {}
}

var result = calculator.Add(new int[] { 1, 2, 2, 4});
