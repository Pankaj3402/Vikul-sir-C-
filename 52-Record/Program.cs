customer c1 = new customer() { firstname = "pankaj", lastname = "more" };

Console.WriteLine($"first name : {c1.firstname} last name : {c1.lastname}");

customer c2 = c1;

//customer c2 = new customer() {firstname = "pankaj",lastname = "more" };

if(c1.Equals(c2))
{
    Console.WriteLine("c1 and c2 are equal");
}
else
{
    Console.WriteLine("c1 and c2 are not equal");
}


customer c3 = c2;
Console.WriteLine($"first name : {c3.firstname} last name : {c3.lastname}");

customer c4 = c3 with { firstname = "kiran" };
Console.WriteLine($"first name : {c4.firstname} last name : {c4.lastname}");