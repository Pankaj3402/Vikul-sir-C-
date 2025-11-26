

//print del = printA;

print del = printB; //2nd delegate instance 


del("pankaj");  //3nd calling delegate 


static void printA(string name)
{
    Console.WriteLine($"welcome {name}");
}

static void printB(string name)
{
    Console.WriteLine($"good morning {name}");
}

Console.Read();



// 1st delegate declaration

public delegate void print(string name); 
    


