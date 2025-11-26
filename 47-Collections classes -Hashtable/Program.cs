using System.Collections;

// Key & Value Pair Collections

Hashtable student = new Hashtable();

student.Add(1, "pankaj");
student.Add(2, "kiran");
student.Add(3, "kishor");
student.Add(4, "abhi");

Console.WriteLine("hashtable student collection are :");
foreach (DictionaryEntry student1 in student)
    Console.WriteLine(student1);
Console.WriteLine();


//Add()

student.Add(5, "prathu");
Console.WriteLine("after student.Add(5, prathu) hashtable are:");
foreach (DictionaryEntry student2 in student)
    Console.WriteLine(student2);
Console.WriteLine();



// ContainsKey()

if (student.ContainsKey(1)) //true
{
    Console.WriteLine("student are present of student.ContainsKey(1) : True");
}
else
{

    Console.WriteLine("student are present of student.ContainsKey(1) : False");
}

if (student.ContainsKey(10)) //false
{
    Console.WriteLine("student are present of student.ContainsKey(10) : True");
}
else
{

    Console.WriteLine("student are present of student.ContainsKey(10) : False");
}
Console.WriteLine();


//ContainsValue()

if(student.ContainsValue("kiran"))
{
    Console.WriteLine("student.ContainsValue(kiran) are present");
}
else
{
    Console.WriteLine("student.ContainsValue(kiran) are not present");
}
Console.WriteLine();


if (student.ContainsValue("pranali"))
{
    Console.WriteLine("student.ContainsValue(pranali) are present");
}
else
{
    Console.WriteLine("student.ContainsValue(pranali) are not present");
}
Console.WriteLine();



//lookup

var val = student[1]; // pankaj
Console.WriteLine($"key : {1} value : {val}");
Console.WriteLine();

//remove(key)

student.Remove(1);
Console.WriteLine($"after remove(1) hashtable are :");
foreach(DictionaryEntry student2 in student)
    { Console.WriteLine(student2); }
Console.WriteLine();


//count

Console.WriteLine($"number of students : {student.Count}");


