public class student : IComparable
{
    public int rollnumber { get; set; }
    public string name { get; set; }
    public string city { get; set; }
    public int age { get; set; }

    public static List<student> GetStudents()
    {
        return new List<student>()
        {
            new student() { rollnumber = 1, name = "pankaj", city = "New York", age = 18 },
            new student() { rollnumber = 2, name = "pranali", city = "New York", age = 21 },
            new student() { rollnumber = 3, name = "kiran", city = "California", age = 25 },
            new student() { rollnumber = 4, name = "shravani", city = "Delhi", age = 20 },

        };
    }
          public int CompareTo(object? obj)
    {
        student s = obj as student;

        return this.age.CompareTo(s.age);  // sort on basis of name
    }
}
