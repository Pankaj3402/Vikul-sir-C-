//Icustomer c1 = new Icustomer(); // cannot create an instance of an interface

Icustomer c1 = new SilverCustomer();
c1.PrintTicket();
Console.WriteLine($"Silver Ticket Amount: {c1.GetTicketAmount()}");

Console.WriteLine();

Icustomer c2 = new GoldCustomer();
c2.PrintTicket();
Console.WriteLine($"Gold Ticket Amount: {c2.GetTicketAmount()}");

Console.WriteLine();


IA a = new A();
a.Print();

IB b = new A();
b.Print();

A a1 = new A();
a1.PrintA();
a1.PrintB();

//a1.Print(); //Error in  Explicit interface way of implementation
((IA)a1).Print(); // Calls IA's Print method
((IB)a1).Print(); // Calls IB's Print method

Console.ReadLine();