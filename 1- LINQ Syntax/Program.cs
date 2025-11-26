

List<student> students = new List<student>()
{
    new student() {rollnumber =1, name = "pankaj", age = 23},
     new student() {rollnumber =2, name = "pranali", age = 20},
      new student() {rollnumber =1, name = "kiran", age = 22},
       new student() {rollnumber =1, name = "abhi", age = 23},
};
Console.WriteLine("all students are:");
foreach (var student in students)
{
    Console.WriteLine($"roll number : {student.rollnumber} name : {student.name} age : {student.age}");
}
Console.WriteLine();




//find all students whose age between 20 to 22

#region without LINQ

List<student> students1 = new List<student>();
foreach (var student in students)
{
    if (student.age >= 20 && student.age <= 22)
    {
        students1.Add(student);
    }
}
Console.WriteLine($"all students whose age between 20 to 22");
foreach (var s in students1)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} age : {s.age}");
}
Console.WriteLine();

#endregion without LINQ

#region with LINQ method syntax

//List<student> student1 = new List<student>();
//foreach(var student in students1)
//{
//    if(student.age>=20 && student.age <=22)
//    {
//        students1.Add(student);
//    }
//}

//IEnumerable<student>students2 =student1.Where(student=>student.age>=20 && student.age<=22);

//Console.WriteLine($"all students between 20 & 22 age");

//foreach (var student in students2)
//{
//    Console.WriteLine($"rollnumber :{student.rollnumber} name : {student.name} age : {student.age}");
//}

#endregion with LINQ method syntax

#region with LINQ Query syntax

//IEnumerable<student>students2 = from student in students1
//                                where student.age>=20 && student.age <= 22
//                                select student;
//Console.WriteLine("all students between 20 & 22");

//foreach(var student in students2)
//{
//    Console.WriteLine($"rollnumber : {student.rollnumber} name : {student.rollnumber} age : {student.age}");
//}

#endregion with LINQ Query syntax