public class A : AB, IA
{

}

public class B : AB, IA
{

}

public interface IA { }

public class AB { }

public static class HelperClass
{
    public static void print(this IA a, string val)
    {
        Console.WriteLine($"Type Name : {a.GetType().Name} val : {val}");
    }

    public static void printAB(this AB a, string val)
    {
        Console.WriteLine($"type name : {a.GetType().Name} val : {val}");
    }
}