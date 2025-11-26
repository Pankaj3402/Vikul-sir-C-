using System.Security.Cryptography;

public class calculator
{
    public int num1;
    public int num2;

    public static calculator operator +(calculator c1, calculator c2)
    {
        calculator c = new calculator();
        c.num1 = c1.num1 + c2.num1;
        c.num2 = c1.num2 + c2.num2;
        return c;
    }

    public static bool operator ==(calculator c1, calculator c2)
    {
        return c1.num1 == c2.num1 && c1.num2 == c2.num2;
    }
    public static bool operator !=(calculator c1, calculator c2)
    {
        return c1.num1 != c2.num1 || c1.num2 != c2.num2;
    }
        
}