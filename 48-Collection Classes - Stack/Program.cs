using System.Collections;

Stack history = new Stack();

// push()  //to add item in stack

history.Push("www.google.com");
history.Push("www.pubg.com");
history.Push("www.facebook.com");
history.Push("www.instagram.com");

Console.WriteLine($"number of sites : {history.Count}"); // count:4
Console.WriteLine();


//pop()  // it returns last item and removes last added item in stack


var site = history.Pop();  //www.instagram.com
Console.WriteLine($"pop() : {site}");
Console.WriteLine($"number of sites : {history.Count}");  // count : 3


// peek()  // it returns last added item without removeing it

var site1 = history.Peek(); // www.instagram.com
Console.WriteLine($"peek() : {site1}");
Console.WriteLine($"number of sites : {history.Count}");  // count : 4