public partial class customer : A
{
    public int Id { get; set; }


    public override void printA()
    {
        Console.WriteLine("printA() method called");

    }

    partial void sample();

    partial void sample()
    {
        Console.WriteLine("partial sample() method called");
    }

}