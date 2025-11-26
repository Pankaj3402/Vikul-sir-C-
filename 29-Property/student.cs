public class student
{
    //public int rollnumber;
    //public string name;
    //public int passmark = 35;

    private int _rollnumer;

    public int rollnumber
    {
        get
        {
            return _rollnumer;
        }
        set
        {
            if (value >  0)
            {
               _rollnumer = value;
            }
            else
            {
                Console.WriteLine("rollnumber cannot be negative");
            }
        }
                     
    }
    private string _name;

    public string Name
   {
        get
        {
            return !string.IsNullOrEmpty(_name) ? _name : "no name";
        }
        set
        {
            _name = value;
        }
           
    }

    private int _passmark = 35;

    public int Passmark
    {
        get
        {
            return _passmark;
        }
    }

    public string email { get; set; }  //Auto implented property
}
