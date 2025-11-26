public interface IA
{
    void Print();
    void PrintA();
    void PrintZ()  // interface members can have body
    {
        Console.WriteLine("common implementation");
    }
}

public interface IB
{
    void Print();
    void PrintB();
}

public class A : IA, IB
{
   public void PrintA()
   {
       Console.WriteLine("IA PrintA() Method");
   }

    public void PrintB()
    {
        Console.WriteLine("IB PrintB() Method");
    }

   void IA.Print()
   {
       Console.WriteLine("IA Print() Method");
   }

    void IB.Print()
    {
        Console.WriteLine("IB Print() Method");
    }
}
public class B : IA
{
    public void Print()
    {
        Console.WriteLine("IA Print() Method");
    }
    public void PrintA()
    {
        Console.WriteLine("IA PrintA() Method");
    }
    // Explicit interface implementation
    void IA.PrintZ()
    {
        Console.WriteLine("B's implementation of IA.PrintZ()");
    }
}





//public void print()
//{
//    Console.WriteLine("IA Print() Method");
//}

//public void PrintA()
//{
//    Console.WriteLine("IA PrintA() Method");
//}

//public void PrintZ()
//{
//    Console.WriteLine("IA PrintZ() Method");
//}