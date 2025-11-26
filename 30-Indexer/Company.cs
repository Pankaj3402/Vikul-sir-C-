public class Company
{
    public string Name { get; set; }
    Employee[] _employees;

    public Company(Employee[] emps)
    {
        _employees = emps;
    }

    public string this[int id]
    {
        get
        {
            foreach(Employee e in _employees)
            {
                if(e.Id==id)
                {
                    return e.name;  
                }
            }
            return "not found";
        }
        set
        {
            foreach(Employee e in _employees)
            {
                if(e.Id==id)
                {
                    e.name = value;
                }
            }
        }
    }

    public void details()
    {
        Console.WriteLine($"Company Name : {Name}");

        Console.WriteLine($"*****ALL EMPLOYEES*****");
        foreach(Employee e in _employees)
        {
            Console.WriteLine($"Id : {e.Id} Name : {e.name} City : {e.city}");
        }
    }

}