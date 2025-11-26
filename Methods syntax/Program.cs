#region Method syntax

// no parameters

//string GetMessage()
//{
//    return "welcomd pankaj";
//}
//string result = GetMessage();

//Console.WriteLine(result);


//string getmessage2(string name)
//{
//    return $"welcome {name}";
//}
//string result = getmessage2("kiran");
//Console.WriteLine(result);


// Method parameters

//void print(string fn, string ln)
//{
//    Console.WriteLine($"fullname : {fn} {ln}");
//}
//print("panakj", "more");

//Console.ReadLine();


bool iseven(int num)
{
    return num % 2 == 0;
}
bool b = iseven(11);
Console.WriteLine($"is 11 even : {b}");

b = iseven(20);
Console.WriteLine($"is 20 even : {b}");

Console.ReadLine();


//void printA(string name)
//{
//    if (name.Length < 3)
//    {
//        return;
//    }
//    Console.WriteLine($"good morning, {name}");
//}
//printA("pankaj");
//printA("om");  // in (om) 2 letters is < 3 this name is not print

//Console.ReadLine();

#endregion
