string s = "paNKAJ";
string upper = s.ToUpper();
Console.WriteLine(upper);

string lower = s.ToLower();
Console.WriteLine(lower);

string capitalize = s.makefirstlettercapital();
Console.WriteLine(capitalize);

string name = "killer";
Console.WriteLine(name.makefirstlettercapital());

A a = new A();
a.print("AAA");
a.printAB("ABAB");


B b = new B();
b.print("BBB");
b.printAB("ABAB");

Console.Read();