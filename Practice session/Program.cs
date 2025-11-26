///  (1) Prime number

Console.WriteLine($"please enter a number");
int number = int.Parse( Console.ReadLine());

bool isprime= true;

for (int i = 2; number > i; i++)
{
    if (number % i == 0)
    {
        isprime = false;
        break;
    }
}
string primeresult = isprime ? "prime" : "Not Prime";
Console.WriteLine($"input number {number} is a {primeresult} number");
Console.ReadLine();



