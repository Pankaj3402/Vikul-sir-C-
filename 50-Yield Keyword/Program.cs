calculator c1 = new calculator();

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

Console.WriteLine(" ***all even numbers ***");

foreach (int number in c1.GetEvenNumbers(numbers))
{
    Console.WriteLine(number);
}