#region Reverse Method

//// it does not sort the items in the list it simply reverse the order of items

//List<int> numbers = new List<int>() { 1, 9, 4, 3, 5, 6, 7, 8, };
//Console.WriteLine("***before reverse***");
//foreach (var number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//numbers.Reverse();
//Console.WriteLine("***after reverse***");
//foreach (var number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

#endregion Reverse Method  

#region OrderBy and OrderByDescending

//// it sort the items in the list in ascending 
//// It returns IOrderedEnumerable<T>


//List<int> numbers = new List<int>() { 6, 2, 3, 9, 5, 1, 7, 8, 4 };
//Console.WriteLine("*** original item*** ");
//foreach (int number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//var ordered = numbers.OrderBy(i => i); //sort in ascending order
//Console.WriteLine("items after numbers.OrderBy(i=>i)");

//foreach (int number in ordered)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();


//// sort in descending order


//ordered = numbers.OrderByDescending(i => i); //sort in descending order
//Console.WriteLine("items after numbers.OrderByDescending(i=>i)");

//foreach (int number in ordered)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();
#endregion OrderBy and OrderByDescending

#region ThenBy and ThenByDescending


/// Use to sort items based on more than one property
/// It sorts in ascending order


//List<student> students = student.GetStudents();
//Console.WriteLine("all students");
//foreach(var item in students)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name}  city : {item.city}  age : {item.age}");
//}
//Console.WriteLine();


//IOrderedEnumerable<student> result = students.OrderBy(s => s.name);
//Console.WriteLine("all student after : students.OrderBy(s => s.name)");
//foreach(var item in result)
//{
//    Console.WriteLine($"rollnumber : {item.rollnumber} name : {item.name}  city : {item.city}  age : {item.age}");
//}
//Console.WriteLine();

//IOrderedEnumerable<student> result1 = result.ThenBy(s => s.age);
//Console.WriteLine("all student after student OrderBy(s=>s.name) result.ThenBy(s => s.age)");
//foreach (var item1 in result1)
//{
//    Console.WriteLine($"rollnumber : {item1.rollnumber} name : {item1.name}  city : {item1.city}  age :{item1.age}");
//}
//Console.WriteLine();


/// Use to sort items based on more than one property
/// It sorts in descending order


//IOrderedEnumerable<student> result3 = result1.ThenByDescending(s => s.age);

//Console.WriteLine("**** ALL STUDENTS AFTER students.OrderBy(s => s.Gender).ThenByDescending(s => s.Age) ****");
//foreach (var item in result3)
//{
//    Console.WriteLine($"roll number : {item.rollnumber} name : {item.name} gender : {item.city} " +
//        $"age : {item.age}");
//}

#endregion ThenBy and ThenByDescending

#region Sort 

//List<int> numbers = new List<int>() { 6, 2, 3, 9, 5, 1, 7, 8, 4 };
//Console.WriteLine("*** original item*** ");
//foreach (int number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

//numbers.Sort(); //sort in ascending order
//Console.WriteLine("items after numbers.Sort()");
//foreach (int number in numbers)
//{
//    Console.Write($"{number}\t");
//}
//Console.WriteLine();

#endregion Sort 

#region Sort Overloads

List<student> students = student.GetStudents();
Console.WriteLine("all students");
foreach (student s in students)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} city : {s.city} age : {s.age}");
}

Console.WriteLine();


//students.Sort(); // it will call CompareTo method of student class
//students.Sort(new studentHelper()); // it will call Compare method of studentHelper class

//students.Sort(0, 3, new studentHelper());

Console.WriteLine("after sort");
foreach(student s in students)
{
    Console.WriteLine($"rollnumber : {s.rollnumber} name : {s.name} city : {s.city} age : {s.age}");
}


#endregion Sort Overloads
