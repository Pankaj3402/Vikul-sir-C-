//we have some pre defined generic delegates

// 1. Predicate<> : T as Input & Bool as Return type
// 2. Action<>    : T as Input & Void as Return type. it has 16 overloads
// 3. Func<>      : T as Input & T as Return type



// 1. Predicate<>

Predicate<string> del1 = s => s.Length > 5;

var r1 = del1("pankaj");
Console.WriteLine(r1); //true

var r2 = del1("om");
Console.WriteLine(r2);  //false


// 2. Action<>

Action<string> del2 = s => Console.WriteLine(s);
del2("pankaj");  //pankaj

Action<int> del3 = s => Console.WriteLine(s);
del3(10);  //10


// 3. Func<>

Func<int, int, int> del4 = (a, b) => a + b;
Console.WriteLine(del4(10,20));  //30


Func<string, string, string, string> del5 = (s1, s2, s3) => 
string.Format($"fullname : {s1},{s2},{s3}");
Console.WriteLine(del5("pankaj" , "machindra" , "more")); //pankaj, machindra, more


Func<string, int> del6 = s => s.Length;
Console.WriteLine(del6("pankaj"));  //6
    

