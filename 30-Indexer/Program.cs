Employee[] employees = new Employee[]
{
    new Employee() {Id = 1, name = "pankaj", city = "pune"},
    new Employee() {Id = 2, name = "kiran", city = "akluj"},
    new Employee() {Id = 3, name = "abhi", city = "sangli"},
    new Employee() {Id = 4, name = "prathu", city = "satara"}
};

Company tcs = new Company(employees) { Name = "TATA CONSULTANCY SERVICES" };
tcs.details();

string name = tcs[1]; //pankaj
Console.WriteLine($"tcs[3] : {name}");

Console.WriteLine($"tcs[3] : {tcs[2]}"); //kiran

tcs[4] = "kishor"; //updated name
Console.WriteLine($"tcs[4] : {tcs[4]}"); //kishor


Console.ReadLine(); 