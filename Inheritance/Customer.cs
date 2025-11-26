
//Base class/Parent class

public class customer  //Base class/Parent class
{
    public int ticketamount;

    public void showstimings()
    {
        Console.WriteLine("****All Todays Show Timings*****");
    }

    public void GetTicketAmount()
    {
        Console.WriteLine($"Ticket Amount : {ticketamount}");
    }
}