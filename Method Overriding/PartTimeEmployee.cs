public class PartTimeEmployee : Employee
{
    public int Hourlywages;

    public override void PrintFullname()
    {
        Console.WriteLine($"Full Name : {firstname} {lastname} : Part Time {Hourlywages} per hour");
    }
}

public class contractor : PartTimeEmployee
{
    public int percentage;

    public override void PrintFullname()
    {
  
        Console.WriteLine($"Full Name : {firstname} {lastname} : contractor {Hourlywages} per hour");
    }
}