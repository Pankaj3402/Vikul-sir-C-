public class Calculator
{
    int num1;
    int num2;

    public Calculator()
    {
        num1 = 10;
        num2 = 20;
    }

    public Calculator(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public Calculator(Calculator c)
    {
        num1 = c.num1;
        num2 = c.num2;
    }

    public void print()
    {
        Console.WriteLine("print() called.");
    }

    //public string print() //no overload
    //{
    //    return "string print() called";
    //}

    public void print(int num)  //method overloaded on number of parameter
    {
        Console.WriteLine($"print ({num}) called");
    }

    public void print(ref int num) //method overloaded on number of parameter
    {
        Console.WriteLine($"print(ref int {num}) called"); 
    }

    //public void Print(out int num) // // no overload as ref already there in one form
    //{
    //    num = 1000;
    //    Console.WriteLine($"Print(out int {num}) Called.");
    //}


    public void print(string name) // method overloading type of parameter
    {
        Console.WriteLine($"print(string {name} called)");
    }

    public void print(int num , string name)
    {
        Console.WriteLine($"print(int {num} string {name}) called");
    }


    public void print(string name , int num) 
    {
         Console.WriteLine($"print(string {name} int {num}) called ");// method overloaded on order of parameter
    }

    //partial void print( params int[] numbers)
    //{

    //} 
}
