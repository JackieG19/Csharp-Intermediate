/*
We use the readonly modifier to improve the robustness of our code.

When a field is declared with readonly, it needs to be
initialized either during declaration or in a constructor.

The value cannot be changed.

This prevents you from accidentally overwriting the value of a field, which can result in an unexpected state.

As an example, think of the Orders in the above example.

If we accidentally re-initialize this field somewhere else in the class,
all the Order objects stored in the list will be lost.

So we should declare it as readonly:*/

public class Customer
{
    public readonly List<Order> Orders = new List<Order>();
}