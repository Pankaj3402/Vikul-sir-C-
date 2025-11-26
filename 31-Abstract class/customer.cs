public abstract class customer
{
    public void ShowTiming()
    {
        Console.WriteLine("***ALL SHOWS***");
    }

    public abstract void PrintTicket();
    
    public static void print()
    {
        Console.WriteLine("static print method called");
    }

   
}

public class SilverCustomer : customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Silver Ticket Printed");
    }
}

public class GoldCustomer : customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Gold Ticket Printed");
    }
}