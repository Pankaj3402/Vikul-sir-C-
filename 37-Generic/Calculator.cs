public class calculator
{
    #region way 1

    //public bool AreEqual(int a , int b)
    //{
    //    return a.Equals(b);
    //}

    //public bool AreEqual(string a , string b)
    //{
    //    return a.Equals(b);
    //}

    #endregion way 1

    #region way 2

    //public bool AreEqual(object a, object b)
    //{
    //    return a.Equals(b);
    //}


    #endregion way 2

    #region way 3 generics

    public bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }


    #endregion way 3 generics
}