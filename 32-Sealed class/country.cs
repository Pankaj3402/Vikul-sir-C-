public class country
{

}
public class india : country { }

public class pakistan : country { }

public sealed class earth { }



class A
{
    public virtual void print() { Console.WriteLine("A"); }

}

class B : A
{
    public sealed override void print()
    {
        Console.WriteLine("B");
    }
}

//class AB :  B  // error due to Class B is sealed
//{
//    public override void print() { Console.WriteLine("AB")};

//}