public class customer
{
    private string firstname;
    private string lastname;

    public customer(string firstname, string lastname)
    {
        firstname = firstname;
        lastname = lastname;
    }

    private bool Isvalid()
    {
        return !string.IsNullOrEmpty(firstname) &&
            !string.IsNullOrEmpty(lastname);
    }

    public void insert()   //Abstraction as it availabe outside
        //encapsulated logic using IsValid() method
    {
        if(Isvalid())
        {
            Console.WriteLine($"customer inserted to database successfully");
        }
        else
        {
            Console.WriteLine($"Invalid customer data");
        }
    }
}