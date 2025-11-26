public interface Icustomer
{
    //cannot have field, constructor, destructor, static members, or constants in an interface

    public int TicketAmount { get; set; }

    void PrintTicket();  //default access specifier is public
    int GetTicketAmount();

}

public class SilverCustomer : Icustomer
{
    public int TicketAmount { get; set; }
    public void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket");
    }
    public int GetTicketAmount()
    {
        return 150;
    }
}

public class GoldCustomer : Icustomer
{
    public int TicketAmount { get; set; }
    public void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
    public int GetTicketAmount()
    {
        return 250;
    }
}
