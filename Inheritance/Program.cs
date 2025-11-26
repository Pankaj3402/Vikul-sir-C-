SilverCustomer sc = new SilverCustomer();
sc.showstimings();
sc.GetTicketAmount();
sc.PrintTicket();


GoldCustomer gc= new GoldCustomer();
gc.showstimings();
gc.GetTicketAmount();
gc.PrintTicket();

PlatinumCustomer pc = new PlatinumCustomer();
pc.showstimings();
pc.GetTicketAmount();
pc.PrintTicket();

//possible objects

customer c1 = new customer();
customer c2 = new SilverCustomer();
customer c3 = new GoldCustomer();
customer c4 = new PlatinumCustomer();

SilverCustomer sc1 = new SilverCustomer();

SilverCustomer sc2v = (SilverCustomer) new customer();


Console.ReadLine();
