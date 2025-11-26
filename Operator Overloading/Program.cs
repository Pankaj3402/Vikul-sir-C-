int a = 10 , b = 20;
int c = a + b;  //+ operator & a,b oprands
Console.WriteLine(c);

string s1 = "pankaj";
string s2 = "pankaj";
if(s1 == s2)
{
    Console.WriteLine($"s1 and s2 are equal");
}
else
{
    Console.WriteLine($"s1 and s2 are not equal");
}


calculator c1 = new calculator() { num1=10 , num2 =20};
calculator c2 = new calculator (){ num1=10 , num2 =20};

if(c1 == c2)
{
    Console.WriteLine("calculator : c1 and c2 are equal");
}
else
{
    Console.WriteLine("calculator : c1 and c2 are not equal");
}

Console.ReadLine();