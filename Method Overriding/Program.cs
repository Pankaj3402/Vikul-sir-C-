Employee e1 = new Employee()
{
    firstname = "sagar",
    lastname = "dudhal"
};
e1.PrintFullname();

Employee e2 = new PartTimeEmployee()
{
    firstname = "amar",
    lastname = "shinde",
    Hourlywages = 200
};
e2.PrintFullname();  //overridden method from PartTimeEmployee class

Employee e3 = new FullTimeEmployee()
{
    firstname = "ganesh",
    lastname = "rathod",
    YearlyPackage = 5
};
e3.PrintFullname();



PartTimeEmployee e4 = new contractor()
{
    firstname = "dipak",
    lastname = "shinde",
    Hourlywages = 200
};
e4.PrintFullname();

Console.ReadLine();