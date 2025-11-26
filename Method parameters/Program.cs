using System.Runtime.InteropServices;

class program
{
    static void main()
    {
        Console.WriteLine("main starts");

        int a = 10, b = 2, add, sub, mul, div;
        add = operation(a, b, out sub, out mul, out div);
        Console.WriteLine($"addition : {a}+{b}={add}");
        Console.WriteLine($"substraction : {a}-{b}-{sub}");
        Console.WriteLine($"multiplication: {a}*{b}={mul}");
        Console.WriteLine($"division : {a}/{b}={div}");


        string status = "dispatched";
        updatestatus(ref status);
        Console.WriteLine($"current status: {status}");

       

       
       

    }
    static int operation(int a, int b, out int sub, out int mul, out int div)
    {
        sub = a - b;
        mul = b * a;
        div = a / b;
        return a + b;
    }
    static void updatestatus(ref string status)
    {
        status = "delivered";
    }

   
}




