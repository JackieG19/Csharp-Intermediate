/* We can use the params modifier to give a method the
ability to receive varying number of parameters.*/
public class Calculator
{
    ...
}
...
public int Add(params int[] numbers)
{
    ...
}
var result = calculator.Add(1, 2, 3, 4);