using System.Text.RegularExpressions;

var students = Student.GetAll();

Console.WriteLine("all students");

foreach (Student s in students)

{
    Console.WriteLine($"rollnumber : {s.RollNumber} name : {s.Name} gender : {s.Gender} age : {s.Age}");
}
Console.WriteLine();


// GroupBy


//IEnumerable<IGrouping<string, Student>> groups = students.GroupBy(s=>s.Gender);  // Method syntax

//IEnumerable<IGrouping<string, Student>> groups = from s in students
//                                                 group s by s.Gender;  // Query syntax



// ToLookup

IEnumerable<IGrouping<string, Student>> groups = students.ToLookup(s=>s.Gender);  // Method syntax

// it does not support query syntax



foreach (var group in groups)
{
    Console.WriteLine($"group name : {group.Key}, Number of items : {group.Count()}");

    foreach (var item in group)
    {
        Console.WriteLine($"rollnumber : {item.Name}");
    }   
}
    