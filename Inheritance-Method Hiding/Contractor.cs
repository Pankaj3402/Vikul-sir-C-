public class contractor : Employee
{
    //public int id;
    //public string name;
    //public string email;
    public int percentage;

    //public new void details()
    //{
    //    Console.WriteLine($"id : {id} name : {name} email : {email}");
    //}

    public new void details()
    {
        Console.WriteLine($"id : {id} name : {name} email : {email}- Contractor");
    }
}