//FIFO : first in first out

using System.Collections;

Queue row = new Queue();


// Enqueue

row.Enqueue("pankaj");
row.Enqueue("kiran");
row.Enqueue("kishor");
row.Enqueue("abhi");

Console.WriteLine($"number in row : {row.Count}"); // 4


// Dequeue

//var person = row.Dequeue();
//Console.WriteLine($"dequeue item are : {person}"); // pankaj
//Console.WriteLine($"numbers of item after dequeue : {row.Count}"); // count=3


// peek

var person1 = row.Peek();
Console.WriteLine($"peek item is : {person1}"); // pankaj
Console.WriteLine($"numbers of item after peek : {row.Count}"); // count=4