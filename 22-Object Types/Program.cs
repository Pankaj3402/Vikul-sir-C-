
#region Var Keyword
object v1 = 10;
object v2 = "pankaj";
object v3 = 10.5f;

// Anonymous type

//object v4 = new { id = 10, name = "pankaj" };
//Console.WriteLine($"id : {v4.id} name : {v4.name}");  //error

var v4 = new { id = 10, name = "panakj" };
Console.WriteLine($"id : {v4.id} name : {v4.name}");


var i = 12;
//i = "pankaj"; //error not conversion possible int to string
var s = "pankaj"; //var keyword show compile time error
var f = 10.5f;
var b = true;

#endregion Var Keyword

#region Dynamic Keyword

dynamic d1 = new customer();
d1.print();
//d1.methodnahihai(); // no error show in compile time
////error shows in run time

object o1 = 10;
Console.WriteLine(o1); //10
o1 = "pankaj";
Console.WriteLine(o1);  //pankaj

var o2 = 10;
//o2 = "pankaj"; //compile time error

dynamic o3 = 10; //dynamic keyword gives run time error
Console.WriteLine($"o3= 10 type : {o3.GetType().Name}"); //Int32
o3 = "mahesh";
Console.WriteLine($"o3= \"mahesh\" type : {o3.GetType().Name}"); //string



    



#endregion  Dynamic Keyword




Console.ReadLine();