class A
{
    public void print() { Console.WriteLine("A"); }
}

class B : A
{
    public new void print() { Console.WriteLine("B"); }
}

class C:B
{
    public new void Print() { Console.WriteLine("C"); }
}