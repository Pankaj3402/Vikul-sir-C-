

public class calculator
{
    #region first

    //public void divide(int a, int b)
    //{
    //    int c = a / b;
    //    Console.WriteLine($"division : {a} / {b} = {c}");
    //}

    #endregion first

    #region second

    //public void divide(int a, int b)
    //{
    //    try
    //    {
    //        int c = a / b;
    //        Console.WriteLine($"division : {a} / {b} = {c}");
    //    }
    //    catch
    //    {
    //        Console.WriteLine("there is some problem with input. please correct your input.");
    //    }
    //}

    #endregion second

    #region third

    public void divide(int a, int b)
    {
        try
        {
            int c = a / b;
            Console.WriteLine($"division : {a}/{b}={c}");

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{ex.GetType().Name} = {ex.Message}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"{ex.GetType().Name} = {ex.Message}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.GetType().Name} = {ex.Message}");
        }


    }
    #endregion third

}

