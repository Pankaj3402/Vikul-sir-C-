public class Employee
{
    public string firstname;
    public string lastname;

    public virtual void PrintFullname()
    {
        Console.WriteLine($"Full Name : {firstname} {lastname}");
    }
}