public partial class customer : A
{
    public void print()
    {
        Console.WriteLine("print() method called");
    }
}

public abstract class A  // the abstract class is not print on console screen
{
    public abstract void printA();
}