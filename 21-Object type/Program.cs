using System.Reflection;

customer c = new customer("pankaj", "more");
Console.WriteLine(c);

Type customerType = c.GetType();
Console.WriteLine($"type name : {customerType.Name}");

FieldInfo[] fields = customerType.GetFields();
foreach (FieldInfo field in fields)
{
    Console.WriteLine($"field name : {field.Name}");
}


Console.WriteLine($"c.tostring() : {c.ToString()}");

customer c1 = new customer("kiran", "more");
customer c2 = new customer("abhi", "more");
if(c1.Equals(c2))
{
    Console.WriteLine("c1 & c2 are equal");
}
else
{
    Console.WriteLine("c1 & c2 are not equal");
}


string fn = "pankaj";
string ln = "more";
string fn1 = "pankaj";
Console.WriteLine($"fn : pankaj : {fn.GetHashCode()}"  + 
    $" ln : more : {ln.GetHashCode()} fn1 : pankaj : {fn1.GetHashCode()} ");
Console.ReadLine();