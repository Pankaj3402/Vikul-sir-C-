public class student
{
    public string firstname;  // instance field
    public string lastname;  // instance field
    public static string trainername; //static field

    public student()
    {
        firstname = "pankaj";
        lastname = "more";
        trainername = "vikul";
        Console.WriteLine("static student() called");
    }

    static student()
    {
        trainername = "vikul";
        Console.WriteLine("static student() called");
    }

    public void print()
    {
        Console.WriteLine($"Full Name : {firstname} {lastname} : {trainername}");
        printA();
    }

    public static void printA()
    {
        Console.WriteLine("printA() method called");
    }
}