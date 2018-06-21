/*By default, when we pass a value type (eg int, char, bool) to a method,
a copy of that variable is sent to the method. So changes applied to that
variable in the method will not be visible upon return from the method.
This can be modified using the ref modifier. When we use the ref modifier,
a reference to the original variable will be sent to the target method.
Don’t use it when defining your methods.*/

public void Weirdo(ref int a)
{
    a += 2;
}
...

var a = 1:
Weirdo(ref a);

// Here a will be 3.
