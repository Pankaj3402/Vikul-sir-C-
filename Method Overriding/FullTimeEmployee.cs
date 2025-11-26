    public class FullTimeEmployee : Employee
{
    public int YearlyPackage;

    public override void PrintFullname()
    {
        Console.WriteLine($"Full Name : {firstname} {lastname} : Full Time {YearlyPackage} LPA");


    }
}