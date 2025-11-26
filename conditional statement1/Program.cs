//conditional statement

#region if statement

//int a = 25, b = 20;

//if (a > b)
//{
//    Console.WriteLine("b is less than a");
//}

//Console.WriteLine("b is greater than a");
//Console.ReadLine();

#endregion

#region if else statement

//int a = 10, b = 20;

//if (a < b)
//{
//    Console.WriteLine("a is less than b");
//}

//else

//{
//    Console.WriteLine("b is greater than a");
//}
//Console.ReadLine();

//int a, b;

//Console.WriteLine("enter the value of a");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter the value of b");
//b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("a is greater than b");
//}
//else
//{
//    Console.WriteLine("a is less than b");
//}
//Console.ReadLine();

#endregion

#region if else if else ladder

//Console.WriteLine("please enter the value");
//int num = int.Parse(Console.ReadLine());

//if (num == 10)
//{
//    Console.WriteLine($"you entered : {num} = ten");
//}
//else if (num == 20)
//{
//    Console.WriteLine($"you entered : {num} = twenty");
//}
//else if (num == 30)
//{
//    Console.WriteLine($"you entered : {num} = thirty");
//}
//else
//    Console.WriteLine($"you entered : {num} = not 10 20 or 30");
//Console.ReadLine();


//int percentage;

//Console.WriteLine("enter your percentage");
//percentage = Convert.ToInt32(Console.ReadLine());

//if (percentage >= 35 & percentage <= 50)
//{
//    Console.WriteLine("you are pass with B grade");
//}
//else if (percentage >= 51 & percentage <= 60)
//{
//    Console.WriteLine("you are pass with B+ grade");
//}
//else if (percentage >= 61 & percentage <= 74)
//{
//    Console.WriteLine("you are pass with A grade");
//}
//else if (percentage >= 75 & percentage <= 90)
//{
//    Console.WriteLine("you are pass with A+ grade");
//}
//else if (percentage >= 91 & percentage <= 100)
//{
//    Console.WriteLine("you are pass with O grade");
//}
//else
//{
//    Console.WriteLine("you are failed, try next time!!!");
//}

#endregion

#region Ternary Operator

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//string result = (num == 10) ? "Ten" : "Not Ten";
//Console.WriteLine($"you entered : {num} = {result}");

//Console.ReadLine();

//Console.WriteLine("please enter a number");
//int num = int.Parse(Console.ReadLine());

//string result = (num <= 100) ? "its true" : "its false";
//Console.WriteLine($"you entered : {num} = {result}");


#endregion

#region switch statement

Console.WriteLine("please enter a number");
int num = int.Parse(Console.ReadLine());

switch (num)

{
    case 10:
        Console.WriteLine($"{num} : TEN");
        break;

    case 20:
        Console.WriteLine($"{num} : TWENTY");
        break;


    case 30:
        Console.WriteLine($"{num} : THIRTY");
        break;


    default:
        Console.WriteLine($"{num} : NOT 10 20 or 30");
        break;
}

Console.ReadLine();

#endregion

#region example 1

//Console.WriteLine("please enter first number");
//int first = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter second number");
//int second = int.Parse(Console.ReadLine());

//if (first>second)
//{
//    Console.WriteLine($"first is greater than second");
//}
//else if (second>first)
//{
//    Console.WriteLine($"second is greater than first");
//}
//else
//{
//    Console.WriteLine($"first & second is equal");
//}
//Console.ReadLine();

#endregion

#region example 2

//using System.ComponentModel.Design;

//Console.WriteLine("please enter first number");
//int first = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter second number");
//int second = int.Parse(Console.ReadLine());

//Console.WriteLine("please enter third number");
//int third = int.Parse(Console.ReadLine());

//if (first>second)
//{
//    if (first>third)
//    {
//        Console.WriteLine($"first is greater than second & third");
//    }
//    else
//    {
//        Console.WriteLine($"third is greater than first & second");
//    }

//}
//else if (second>first)
//{
//    if (second>third)
//    {
//        Console.WriteLine($"second is greater than first & third");
//    }
//    else
//    {
//        Console.WriteLine($"third is greater than first & second");
//    }
//}
//else
//{
//    if (third>first)
//    {
//        Console.WriteLine($"third is greater than first & second");
//    }
//    else if (first>third)
//    {
//        Console.WriteLine($"first & second is greater than third");
//    }
//    else
//    {
//        Console.WriteLine($"first second & third numbers are equal");
//    }

//}
//Console.ReadLine();

#endregion
