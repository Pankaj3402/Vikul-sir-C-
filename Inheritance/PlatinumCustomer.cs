public class PlatinumCustomer : customer
{
    #region before inheritance

    //public int TicketAmount = 500;

    //public void GetTicketAmount()
    //{
    //    Console.WriteLine($"Ticket Amount : {ticketamount}");
    //}

    //public void ShowsTiming()
    //{
    //    Console.WriteLine($"***All Todays Show Timings ***");
    //}
    #endregion  before inheritance

    public PlatinumCustomer()
    {
        ticketamount = 500;
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Platinum Ticket Printed");
    }
}