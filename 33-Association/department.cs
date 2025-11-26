public class employee   //child class
{
    public int Id { get; set; }
    public string name { get; set; }

    public department department { get; set; }

}

public class department   // Parent class
{ 
    public string name { get; set; }

    public employee[] employees { get; set; }
}
