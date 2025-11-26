using System.Security.AccessControl;

public class car
{
    public string Name { get; set; }
    public car()
    {
        Name = "regular car";
    }
    public class Audi : car
    {
        public Audi()
        {
            Name = "Audi";
        }
    }
    public class Bmw : car
    {
        public Bmw()
        {
            Name = "Bmw";
        }

    }
}