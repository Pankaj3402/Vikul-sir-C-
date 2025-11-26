public class customer
{
    public string firstname;
    public string lastname { get; set; }

    public customer (string fn, string ln)
    {
        firstname = fn;
        lastname = ln;
    }

    public void Display()
    {
        Console.WriteLine($"first name : {firstname} last name : {lastname}");
    }
}

