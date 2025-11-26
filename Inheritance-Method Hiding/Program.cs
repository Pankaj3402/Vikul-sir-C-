FullTimeEmployee e1 = new FullTimeEmployee()

//Employee e1 = new FullTimeEmployee()

{
    id = 1,
    name = "yogesh",
    email = "ym@gmail.com",
    YearlyPackage = 4
};
e1.details();

PartTimeEmployee e2 = new PartTimeEmployee()
//Employee e2 = new PartTimeEmployee()
{
    id = 2,
    name = "appa",
    email = "apemail.com",
    HourlyWages = 100

};  

e2.details();


contractor c1 = new contractor()
{
    id =3,
    name = "pappa",
    email = "pa@email.com"
};

c1.details();

Console.ReadLine();