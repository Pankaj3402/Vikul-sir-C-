using System.Runtime.InteropServices;

public class student
{
    public string firstname;
    public string lastname;

    public student(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        //print();
        this.print();
    }
   public void print()
    {
        Console.WriteLine($"Full Name : {firstname} {lastname}");
    }
}