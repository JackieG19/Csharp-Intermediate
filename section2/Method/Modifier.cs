// The Params Modifier

public class Calculator
{
    public int Add(params int[] numbers){}
}

var result = calculator.Add(new int[] { 1, 2, 2, 4});
var result = calculator.Add(1, 2, 3, 4);


// The Ref Modifier

public class MyClass
{
    public void MyMethod(int a)
    {
        a += 2;
    }
}

var a = 1;
myClass.MyMethod(a);


public class Weirdo
{
    public void DoAWeirdThing(ref int a)
    {
        a += 2;
    }
}


// The Out Modifier

public class MyClass
{
    public void MyMethod(out int result)
    {
        result = 1;
    }
}

int a;
myClass.MyMethod(out a);






