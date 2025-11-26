public class order
{
    public int Id { get; set; }
    public string Discription { get; set; }

}

public class customer
{ 
    public string name { get; set; }    

    public Lazy<List<order>> orders { get; set; }

    public customer()
    {
        name = "pankaj";

        orders = new Lazy<List<order>>(() => GetOrders());
    }
    public List<order> GetOrders()
    {
        return new List<order>()
        {
            new order() { Id = 1, Discription = "Order 1" },
            new order() { Id = 2, Discription = "Order 2" },
            new order() { Id = 3, Discription = "Order 3" },
        };
    }
}
