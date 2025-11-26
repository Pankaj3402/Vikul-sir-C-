
//Derived class / Child class

public class SilverCustomer : customer  // inheritance
{
    #region before inheritance

    //    public int TicketAmount = 150;

    //    public void GetTicketAmount()
    //    {
    //        Console.WriteLine($"Ticket Amount : {TicketAmount}");
    //    }

    //    public void ShowsTimings()
    //    {
    //        Console.WriteLine($"*****All Todays Show timings");
    //    }


    #endregion before inheritance

    public SilverCustomer()
    {
        ticketamount = 150;
    }

    public void PrintTicket()
    {
        Console.WriteLine("silver ticket printed");
    }
}