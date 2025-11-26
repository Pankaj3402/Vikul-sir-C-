using System.Collections;

#region ArrayList

//ArrayList numbers = new ArrayList();

////Add()

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3); 
//numbers.Add(4);

//Console.WriteLine("all numbers");
//foreach (int i in numbers)
//{ Console.WriteLine(i); }

//Console.WriteLine("after Adding item Arraylist items are :");

//foreach(int i in numbers) //1,2,3,4
//{
//    Console.Write($"\t {i}" );
//}
//Console.WriteLine();


////AddRange()

//ICollection item1 = new ArrayList() { 5, 6, 7 };
//numbers.AddRange(item1);
//Console.WriteLine("items in arraylist after numbers.AddRange(item1) are :");

//foreach(int i in numbers)  //1 2 3 4 5 6 7
//{
//    Console.WriteLine(i);
//}

////Count()

//Console.Write($"total numbers are: {numbers.Count}");  // 7
//Console.WriteLine();


////RemoveAt()

//numbers.RemoveAt(1); // 1 3 4 5 6 7
//Console.WriteLine($"after RemoveAt(1) numbers are:");

//foreach(int i in numbers)
//{
//    Console.WriteLine(i);
//}


////Remove()

//numbers.Remove(3);  // 1 4 5 6 7
//Console.WriteLine("after numbers.Remove(1) items are : ");

//foreach (int i in numbers)
//Console.WriteLine(i);


////Clear

////numbers.Clear();  // 0
////Console.WriteLine($"after removing all items count are : {numbers.Count}");


////Insert()

//numbers.Insert(5, 8);  // 1 4 5 6 7 8
//Console.WriteLine("after insert item numbers.Insert(5, 8) ");

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}


////InsertRange()

//ArrayList item2 = new ArrayList() {9,10,11};
//numbers.InsertRange(0, item2);  // 9 10 11 1 4 5 6 7 8 

//Console.WriteLine("after InsertRange items are :");
//foreach(int item in numbers)
//{
//    Console.WriteLine(item);
//}


//// Capacity
//ArrayList item3 = new ArrayList(4);  // capacity = 4
//Console.WriteLine($"capacity of items in arraylist items3 are: {item3.Capacity}");

#endregion ArrayList

#region HashTable

////FIFO : first in first out

//Queue row = new Queue();


//// Enqueue

//row.Enqueue("pankaj");
//row.Enqueue("kiran");
//row.Enqueue("kishor");
//row.Enqueue("abhi");


//Console.WriteLine("all items");
//foreach (var s in row)
//{ Console.WriteLine(s); }

//Console.WriteLine($"number in row : {row.Count}"); // 4


//// Dequeue

////var person = row.Dequeue();
////Console.WriteLine($"dequeue item are : {person}"); // pankaj
////Console.WriteLine($"numbers of item after dequeue : {row.Count}"); // count=3


//// peek

//var person1 = row.Peek();
//Console.WriteLine($"peek item is : {person1}"); // pankaj
//Console.WriteLine($"numbers of item after peek : {row.Count}"); // count=4

#endregion HashTable

#region Stack

//Stack history = new Stack();

//// push()  //to add item in stack

//history.Push("www.google.com");
//history.Push("www.pubg.com");
//history.Push("www.facebook.com");
//history.Push("www.instagram.com");


//Console.WriteLine("all websites");
//foreach (var s in history)
//{ Console.WriteLine(s); }

//Console.WriteLine($"number of sites : {history.Count}"); // count:4
//Console.WriteLine();


////pop()  // it returns last item and removes last added item in stack


////var site = history.Pop();  //www.instagram.com
////Console.WriteLine($"pop() : {site}");
////Console.WriteLine($"number of sites : {history.Count}");  // count : 3


//// peek()  // it returns last added item without removeing it

//var site1 = history.Peek(); // www.instagram.com
//Console.WriteLine($"peek() : {site1}");
//Console.WriteLine($"number of sites : {history.Count}");  // count : 4

#endregion Stack

#region Queue

////FIFO : first in first out

//Queue row1 = new Queue();


//// Enqueue

//row1.Enqueue("pankaj");
//row1.Enqueue("kiran");
//row1.Enqueue("kishor");
//row1.Enqueue("abhi");


//Console.WriteLine("all items");
//foreach (var s in row1)
//{ Console.WriteLine(s); }


//Console.WriteLine($"number in row : {row1.Count}"); // 4


//// Dequeue

////var person = row.Dequeue();
////Console.WriteLine($"dequeue item are : {person}"); // pankaj
////Console.WriteLine($"numbers of item after dequeue : {row.Count}"); // count=3


//// peek

//var person2 = row1.Peek();
//Console.WriteLine($"peek item is : {person2}"); // pankaj
//Console.WriteLine($"numbers of item after peek : {row1.Count}"); // count=4

#endregion Queue
