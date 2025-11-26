//customer c1 = new customer();

customer c1 = new SilverCustomer();
c1.ShowTiming();
c1.PrintTicket();

customer c2 = new GoldCustomer();
c2.ShowTiming();
c2.PrintTicket();


Console.ReadLine();