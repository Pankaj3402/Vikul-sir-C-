customer c1 = new customer()
{
    firstname = "pankaj",
    lastname = "more",
    

};

var n= customer.Nationality;

var c= customer.Capital;

Console.WriteLine($"firstname :{c1.firstname} lastname : {c1.lastname} " +
    $"nationality : {customer.Nationality} capital : {customer.Capital}");


//customer.Nationality = "canada"; //we cannot change value of const field
//customer.Capital = "mumbai"; // we cannot change value of readonly field

Console.ReadLine();



