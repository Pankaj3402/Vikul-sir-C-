public class PartTimeEmployee : Employee
{
    //public int id;
    //public string name;
    //public string email;
    public int HourlyWages;

    //public void details()
    //{
    //    Console.WriteLine($"id : {id} name : {name} email : {email}");
    //}

    public new void details()
    {
        Console.WriteLine($"id : {id} name : {name} email : {email} - part time");
    }


}