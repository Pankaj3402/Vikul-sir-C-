using System.Collections.Generic;

#region List<>

//List<int> numbers = new List<int>();

////Add()

//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);
//numbers.Add(40); //10 20 30 40

//Console.WriteLine($"number of items : {numbers.Count}"); // 4

//Console.WriteLine("all numbers are :");
//foreach(int i in numbers)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine();


////AddRange()

//numbers.AddRange(new List<int>(){50,60,70});

//Console.WriteLine($"all numbers after AddRange");
//foreach(int i in numbers)
//    Console.WriteLine(i);  // 10 20 30 40 50 60 70

//Console.WriteLine();


//// Incert(index,number)

//numbers.Insert(7,80);
//Console.WriteLine("all numbers after insert");
//foreach (int i in numbers)
//    Console.WriteLine(i); // 10 20 30 40 50 60 70 80
//Console.WriteLine();


//// RemoveAt(index)

//numbers.RemoveAt(7); // 10 20 30 40 50 60 70
//Console.WriteLine("all numbers after RemoveAt(7)");
//foreach(int i in numbers)
//    Console.WriteLine(i);
//Console.WriteLine();


////Remove(number)

//numbers.Remove(70);  // 10 20 30 40 50 60
//Console.WriteLine("all numbers after Remove(70)");
//foreach(int i in numbers)
//    Console.WriteLine(i);
//Console.WriteLine();


////RemoveAll()

//numbers.RemoveAll(i => i < 20);  // 20 30 40 50 60
//Console.WriteLine("all numbers after RemoveAll(i => i > 20)");
//foreach(int i in numbers)
//    Console.WriteLine(i);
//Console.WriteLine();


//// RemoveRange(index,count)

//numbers.RemoveRange(2, 3);  // 20 30
//Console.WriteLine("all numbers after RemoveRange(2,3)");
//foreach(int i in numbers)
//    Console.WriteLine(i);



#endregion List<>

#region dictionary<>

//Dictionary<int,string> students = new Dictionary<int, string>();

//// Add()

//students.Add(1, "pankaj");
//students.Add(2, "kiran");
//students.Add(3, "pranali");
//students.Add(4, "abhi");

//Console.WriteLine("all students are");
//foreach(var student in students)
//{
//    Console.WriteLine(student);
//}
//Console.WriteLine();


//// count

//Console.WriteLine($"total number of student : {students.Count}");
//Console.WriteLine();


//// ContainsKey()

//bool b1 = students.ContainsKey(1);  // true
//Console.WriteLine($"key 1 is exists : {b1}");
//Console.WriteLine();

//// ContainsValue()

//b1 = students.ContainsValue("pankaj"); //true
//Console.WriteLine($"value pankaj is exists : {b1}");
//Console.WriteLine();

//b1 = students.ContainsValue("prathu"); //false
//Console.WriteLine($"value prathu is exists : {b1}");
//Console.WriteLine();

#endregion dictionary<>

#region stack<>

//Stack<string>names = new Stack<string>();

//// Push()

//names.Push("pankaj");
//names.Push("kiran");
//names.Push("pranali");
//names.Push("prathu");

//Console.WriteLine("all names are");
//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"total numbers after pop() : {names.Count}"); //4
//Console.WriteLine();


////pop()

//string name = names.Pop(); //prathu
//Console.WriteLine($"all names after pop() : {name}");
//Console.WriteLine($"total numbers after pop() : {names.Count}"); //3
//Console.WriteLine();


//// Peek()

//string name1 = names.Peek();  // pranali
//Console.WriteLine($"all names after peek() : {name1}");
//Console.WriteLine($"total numbers after peek() : {names.Count}"); //3


#endregion stack<>

#region Queue<>

//Queue<string> row = new Queue<string>();

////Enqueue()

//row.Enqueue("pankaj");
//row.Enqueue("kishor");
//row.Enqueue("sachin");
//row.Enqueue("nitin");

//Console.WriteLine("all items are :");
//foreach(string s  in row)
//    Console.WriteLine(s);
//Console.WriteLine($"total number of items : {row.Count}");
//Console.WriteLine();


////Dequeue()

//string name = row.Dequeue();  // pankaj
//Console.WriteLine($"row.Dequeue() : {name}");
//Console.WriteLine($"total number of items after row.Dequeue() : {row.Count}"); //3
//Console.WriteLine();


////peek()

//string name1 = row.Peek(); //kishor
//Console.WriteLine($"row.Peek() : {name1}");
//Console.WriteLine($"total number of items after row.Peek() : {row.Count}"); //3

#endregion Queue<>