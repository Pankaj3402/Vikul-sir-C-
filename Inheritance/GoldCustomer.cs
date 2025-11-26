public class GoldCustomer : customer
{
    #region  before inheritance

    //public int TicketAmount = 300;

    //public void GetTicketAmount()
    //{
    //    Console.WriteLine($"Ticket Amount : {TicketAmount}");
    //}

    //public void ShowsTiming()
    //{
    //    Console.WriteLine($"****All Todays Show Timings****");
    //}


    #endregion before inheritance

    public GoldCustomer()
    {
        ticketamount = 300;
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Gold Ticket Printed");
    }
}