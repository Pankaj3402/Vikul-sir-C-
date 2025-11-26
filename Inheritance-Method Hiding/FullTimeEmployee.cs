public class FullTimeEmployee : Employee
{
    //public int id;
    //public string name;
    //public string email;
    public int YearlyPackage;

    //public void details()
    //{
    //    Console.WriteLine($"id : {id} name : {name} email : {email}");
    //}

    public new void details()
    {
        Console.WriteLine($"id : {id} name : {name} email : {email}-Full Time");
    }

}