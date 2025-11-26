//// Array in C#

#region Arrays in looping statement
////string name = "pankaj more";

//string[] names = new string[3];

//Console.WriteLine($"number  of items:{names.Length}");

//names[0] = "kiran";
//names[1] = "abhi";
//names[2] = "prathu";

//for (int i = 0; i < names.Length; i++)
//{
//    Console.Write($"{names[i]}\t");
//}
//Console.WriteLine();
//Console.ReadLine();


////array initializer syntax

//string[] boys = new string[] { "pankaj", "kiran", "abhi" };
//Console.WriteLine($"number of boys : {boys.Length}");

//for (int i = 0; i < boys.Length; i++)
//{
//    Console.Write($"{boys[i]}\t");
//}

//Console.WriteLine();

#endregion

#region prime number example

//Console.WriteLine("please enter the number");
//int num = int.Parse(Console.ReadLine());

//bool isprime = true;

//for (int i = 2; i < num; i++)
//{
//    if (num % i == 0)
//    { 
//    isprime = false;
//        break; // exit the loop if a divisor is found
//    }
//}
//string primeresult = isprime ? "prime" : "not prime";
//Console.WriteLine($"input number {num} is a {primeresult} number");
//Console.Read();

#endregion

#region reverse string example

//Console.WriteLine("please enter a string");
//string input = Console.ReadLine();

//string reversestring = string.Empty;

//for (int i = input.Length - 1; i >= 0; i--)
//{
//    reversestring += input[i].ToString();
//}
//Console.WriteLine($"input:{input} reveresed string : {reversestring}");
//Console.ReadLine();
#endregion

#region reverse words in sentence example

//Console.WriteLine(" please enter a sentence ");
//string sentence = Console.ReadLine();

//string[] words = sentence.Split(' ');
//string[] output = new string[ words.Length ];

//for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
    //{
    //    output[j] = words[i];
    //}
    //foreach (string w in output)
    //{
    //    Console.Write($" {w} ");
    //}
    //Console.ReadLine();
    #endregion


    ///Array in looping statement

    //string[] names = new string[3];

    //Console.WriteLine($"number of students : {names.Length}");

    //names[0] = "pankaj";
    //names[1] = "kiran";
    //names[2] = "pranali";

    //for(int i = 0; i < names.Length; i++)
    //{
    //    Console.WriteLine($"{names[i]} \t" );
    //}
    //Console.ReadLine();


    //int[] numbers = new int[3] {10,20,30};
    //Console.WriteLine($"total numbers = {numbers.Length}");

    //for(int i = 0;i< numbers.Length;i++)
    //{
    //    Console.WriteLine($"{numbers[i]} \t");
    //}



    //prime number

    //Console.WriteLine($"please enter a number");
    //int num = int.Parse( Console.ReadLine() );

    //bool isprime = true;

    //for ( int i = 2; i < num; i++ )
    //{
    //    if (num % i == 0)
    //    {
    //         isprime = false;
    //        break;
    //    }


    //}
    //string PrimeResult = isprime ? "Prime" : "Not Prime";
    //Console.WriteLine($"Your Entered number {num} is {PrimeResult} number");

    //Console.ReadLine();




    //reverse string example

    //Console.WriteLine("please enter a string");
    //string input = Console.ReadLine();

    //string reversestring = string.Empty;

    //for(int i = input.Length -1; i >= 0; i--)
    //{
    //    reversestring += input [i]; 
    //}
    //Console.WriteLine($"input : {input} reversedstring : {reversestring}");
    //Console.ReadLine();



    //reverse word in sentence


//Console.WriteLine("please enter a sentence");
//string sentence = Console.ReadLine();

//string[] words = sentence.Split(' ');
//string[] output = new string[words.Length];

//for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
//{
//    output[j] = words[i];
//}
//foreach (string word in output)
//{
//    Console.Write($" {word} ");
//}
//Console.ReadLine();