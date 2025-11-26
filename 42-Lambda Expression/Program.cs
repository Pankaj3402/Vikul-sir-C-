PrintDelegate del1 = () =>
{
    Console.WriteLine("lambda expression 1 called");
};
del1 ();



student del2 = name => Console.WriteLine($"welcom, {name}");
del2("pankaj");



fullname del3 = (s1, s2) => string.Format($"fullname : {s1} {s2}");
string fullname = del3("pankaj", "more");
Console.WriteLine(fullname);


//Add del4 = (a, b) =>
//{
//    int c = a + b;
//    return c;
//};
//int add = del4(10, 20);
//Console.WriteLine($"Addition : {add}");



Add del4 = (a, b) => a + b;
int add = del4(10, 20);
Console.WriteLine(add);