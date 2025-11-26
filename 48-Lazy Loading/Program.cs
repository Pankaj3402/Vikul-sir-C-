customer c = new customer();

Console.WriteLine($"customer name : {c.name}");

Console.WriteLine("****All Orders****");


foreach(order order in c.GetOrders())
{
    Console.WriteLine($"order id : {order.Id} descreption : {order.Discription}");
}

Console.Read();