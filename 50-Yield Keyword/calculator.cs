public class calculator
{
    public IEnumerable<int> GetEvenNumbers(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }
}