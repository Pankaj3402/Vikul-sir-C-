public class calculator
{
    #region way 1

    //public void divide(int a, int b)
    //{
    //    try
    //    {
    //        int c = a / b;
    //        Console.WriteLine($"division : {a} / {b} = {c}");

    //    }
    //    catch(Exception e)
    //    {
    //        Console.WriteLine($"inner catch : {e.Message}");
    //        throw;
    //    }
        
    //}


    #endregion way 1

    #region recommended way

    public void divide(int a, int b)
    {
        try
        {
            if(b!=0)
            {
                int c = a / b;
                Console.WriteLine($"division : {a}/{b}={c}");
            }
            else
            {
                Console.WriteLine("denominator cannot be zero");
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine ($"{ex.Message}");
        }
    }


    #endregion recommended way
}