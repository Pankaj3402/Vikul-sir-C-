
///Looping statement

#region While loop

//int i = 1;  //initialization
//while (i <= 0)  //condition)    //it is not shown on console screen
//{
//    Console.WriteLine($"{i} \t");
//    i++;  //updation
//}
//Console.Read();


int i = 1;
while (i < 10)
{
    Console.WriteLine($"{i} \t");
    i++;
}
Console.ReadLine();
#endregion

#region Do-While loop

//int i = 1;
//do
//{
//    Console.WriteLine($"{i}\t");
//    i++;
//}
//while (i < 0);    //it is shown at least one time


//int i = 1;
//do
//{
//    Console.WriteLine($"{i} \t");
//    i++;
//}
//while (i <= 15);
#endregion

#region For loop

//for (int i=1; i<=10; i++)
//{
//    Console.WriteLine($"{i}\t");
//}


//int i = 1;

//for (; i <= 10;)
//{
//    Console.WriteLine($"{i}\t");
//    i++;
//}
//   Console.ReadLine();


#endregion

#region For-Each loop 

//int[] numbers = new int[] { 10, 20 };
//numbers[2] = 30; /// adding new item // error due to arry size is fixed

int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };

//1//

//for (int i = 0; i < numbers1.Length; i++)
//{ 
//    Console.Write($" {numbers1[i]} ");
//}
//Console.WriteLine();
//Console.ReadLine();

//2//

//foreach (int item in numbers1)
//{
//    Console.Write($" {item} ");
//}
//Console.WriteLine();

//Console.ReadLine();

//3//

//int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
//int sum = 0;

//foreach (int num in numbers2)
//{
//    sum += num;
//}

//Console.WriteLine($"addition of all numbers : {sum}");
//Console.Read();



#endregion

//Break and Continue Statement

#region Break statement 

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }
//    Console.Write($"{i} ");
//}
//Console.ReadLine();

#endregion

#region Continue statement

//for (int i = 1; i <= 10; i++)
//{

//    if (i == 4)
//    {
//        continue;
//    }
//    Console.Write($"{i}\t");
//}
//Console.ReadLine();

#endregion

#region Example

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5; j++)
//    {
//        Console.Write($"*\t");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();


//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"*\t");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();



//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5; j++)
//    {
//        if (i == j)
//        {
//            Console.Write($"*\t");
//        }
//        else
//        {
//            Console.Write($"\t");
//        }
//    }
//    Console.WriteLine();
//}
//Console.Read();


#endregion