public class engine
{
    public int PowerinCC {  get; set; }

}

public class car
{
    public engine engine {  get; set; }
    public car()
    {
        engine = new engine()
        {
            PowerinCC = 1500
        };
       
    }
}