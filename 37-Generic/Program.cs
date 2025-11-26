calculator c1 = new calculator();
bool isequal = c1.AreEqual(10, 10);
Console.WriteLine($"Is 10 & 10 are equal? : {isequal}");

//calculator c2 = new calculator();
//bool isqual = c2.AreEqual("pankaj", "pankaj");
//Console.WriteLine($"Is pankaj & pankaj are equal : {isequal}");

//bool isequal = c1.AreEqual(10.5f, true);
//Console.WriteLine($"Is 10.5f & true are equal : {isequal}");

isequal = c1.AreEqual<float>(10.5f, 15.5f);
Console.WriteLine($"float values are equal : {isequal}");


mathcalculator<int, int, int> m1 = new mathcalculator<int, int, int>();
m1.number1 = 15;
m1.number2 = 20;
int Add = m1.Add();
Console.WriteLine($"Result = {Add}");



Console.ReadLine();