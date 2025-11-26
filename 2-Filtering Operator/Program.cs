List<student> students = new List<student>()
{
    new student(){rollnumber=1,name="pankaj",age=23,city="pune"},
     new student(){rollnumber=2,name="pranali",age=20,city="sangli"},
      new student(){rollnumber=3,name="abhi",age=23,city="pune"},
       new student(){rollnumber=4,name="kiran",age=22,city="akluj"}
};

Console.WriteLine("all students");

foreach (student s in students)
{
    Console.WriteLine($"rollnumber : { s.rollnumber} name : {s.name} city : {s.city} age : {s.age}");
}
Console.WriteLine();




// filter all students who belongs to pune city



var students1 = students.Where(s => s.city.Equals("pune"));

Console.WriteLine("all students from pune city");

foreach(student s in students1)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} city : {s.city} age : {s.age}");
}
Console.WriteLine();


// multi type item collection
List<object> list = new List<object>() { 10, "pankaj",15,24, '$', 10.5f,20.4f };
var student2 = list.OfType<float>();
Console.WriteLine("float values are:");
foreach(var item in student2)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var student3 = list.OfType<int>();

Console.WriteLine("int values are:");
foreach (var item in student3)
{
    Console.WriteLine(item);
}
Console.WriteLine();


//filter all bmw cars from list of cars

List<car> cars = new List<car>()
{
    new car(),
    new car.Audi(),
    new car.Bmw(),
    new car(),
    new car.Bmw(),
    new car.Audi()
};

var carResult = cars.OfType<car.Bmw>();
foreach(var car in carResult)
{
    Console.WriteLine(car.Name);
}