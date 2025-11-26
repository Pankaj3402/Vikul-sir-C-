

Console.WriteLine("welcome to basic calculator app");
string choice = string.Empty;

do
{
    Console.WriteLine("please enter the value of a");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("please enter the value of b");
    int num2 = int.Parse(Console.ReadLine());

    try
    {
        calculator c1 = new calculator();
        c1.divide(num1, num2);
    }

    catch (Exception ex)
    {
        Console.WriteLine($"outer catch block : {ex.GetType().Name}");
    }

    Console.WriteLine("do you want to continue ");
    choice = Console.ReadLine().ToUpper();
}
while (choice == "Y" || choice == "YES");


Console.ReadLine();