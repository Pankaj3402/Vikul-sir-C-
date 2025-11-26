
#region not good way
//calculator c1 = new calculator();

//try
//{
//    Console.WriteLine("please enter numerator");
//    int num = int.Parse(Console.ReadLine());

//    Console.WriteLine("please enter denominator");
//    int den = int.Parse(Console.ReadLine());

//    try
//    {
//        c1.divide(num, den);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"outer catch : {ex.Message}");

//    }
//}
//catch(FormatException ex)
//{
//    Console.WriteLine($"outer catch : { ex.Message}");
//}
//catch(OverflowException ex)
//{
//    Console.WriteLine($"outer catch : {ex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"outer catch : {ex.Message}");
//}

#endregion not good way

#region recommended way

calculator c1 = new calculator();

try
{
    Console.WriteLine("please enter the numerator");

    int num;
    if(int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("please enter the denomenator");

        int den;
        if (int.TryParse(Console.ReadLine(), out den))
        {
             c1?.divide(num, den); 
        }
        else
        {
            Console.WriteLine("please enter a correct denominator");
        }
    }
    else
    {
        Console.WriteLine("please enter a correct numerator");
    }
}
catch(Exception ex)
{
    Console.WriteLine($"outer catch : {ex.Message}");
}
#endregion recommended way