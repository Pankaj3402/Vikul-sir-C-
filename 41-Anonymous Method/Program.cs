
//Using Anonymous Method

PrintDelegate del1 = delegate ()
{
    Console.WriteLine("Anonymous Method Caleed");
};
del1();



AddDelegate add1 = delegate (int a, int b)
{
    return a + b;
};
int result = add1(10, 20);
Console.WriteLine($"Addition : {result}");



printdel del = delegate (string fn, string ln)
{
return fn + ln;
};
string result1 = del("pankaj", "more");
Console.WriteLine($"Name : {result1}");


getlenth l1 = delegate(string s)
{
return s.Length; 
};

int length = l1("kiran");
Console.WriteLine(length);





