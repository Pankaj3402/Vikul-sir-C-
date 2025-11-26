public class A
{
    public virtual void print()
    {
        Console.WriteLine("A");
    }
}

public class B : A
{
    public override void print()
    {
        Console.WriteLine("B");
    }
}

public class C : A
{
    public override void print()
    { 
        Console.WriteLine("C");
    }
}

//public class D : B,C  //cannot create multiple class 


