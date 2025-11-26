customer c1 = new customer();

customer c2 = new SilverCustomer();

customer c4 = null;

SilverCustomer c5 = (SilverCustomer)c4;

object o1 = new student();

SilverCustomer c6 = o1 as SilverCustomer;

if (c6 == null)
{
    Console.WriteLine("unable to cast student to silvercustomer");
}
else
{
    Console.WriteLine("conversion success");
}


if(o1 is SilverCustomer)
{
    Console.WriteLine("o1 is type of silvercustomer");
}
else
{
    Console.WriteLine("o1 is not type of silvercustomer");
}