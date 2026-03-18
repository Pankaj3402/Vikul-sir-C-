//int i = 1;
//while (i < 10)
//{
//    Console.WriteLine($"{i} \t");
//    i++;
//}
//Console.ReadLine();


//public class Demo
//{
//    public void Show()
//    {
//        Console.WriteLine("show method");
//    }
//}

//public class Demo1
//{
//    public void Display()
//    {
//        Console.WriteLine("display method");
//    }
//}

//int i = 1;
//do
//{
//    Console.WriteLine($"{i}\t");
//    i++;
//}
//while (i < 3);    //it is shown at least one time



//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{i}\t");
//}


//int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
//int sum = 20;

//foreach (int num in numbers2)
//{
//    sum += num;
//}

//Console.WriteLine($"addition of all numbers : {sum}");
//Console.Read();

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.Write($"{i} ");
//}
//Console.ReadLine();



//for (int i = 1; i <= 5; i++)
//{

//    Console.WriteLine($"*\t");
//}
//Console.ReadLine();
//for (int j = 1; j <= 5; j++)
//{
//    Console.Write($"*\t");
//}
//Console.WriteLine();







//string name = "pankaj more";

string[] names = new string[3];

Console.WriteLine($"number  of items:{names.Length}");

names[0] = "kiran";
names[1] = "abhi";
names[2] = "prathu";

for (int i = 0; i < names.Length; i++)
{
    Console.Write($"{names[i]}\t");
}
Console.WriteLine();
Console.ReadLine();