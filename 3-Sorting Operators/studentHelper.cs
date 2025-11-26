public class studentHelper : IComparer<student>
{
    public int Compare(student x, student y)
    {
        return x.age.CompareTo(y.age);  // sort on basis of name
    }
}
