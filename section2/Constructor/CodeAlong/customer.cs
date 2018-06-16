  namespace CsharpIntermediate
{
     public class Customer
        {
            public int Id;
            public string Name;
            public List<Order> Orders;

            public ClassName()
            {
                Orders = new List<Order>();
            }

            public ClassName(int id)
                : this()
            {
                this.Id = id;
            }

            public ClassName(int id, string name)
                : this(id)
            {
                // this.Id = id;
                this.Name = name;
            }
        }
}