public class customer
{
    public string name {  get; set; }

    public override bool Equals(object? obj)
    {
        customer c = obj as customer;
        return this.name.Equals(c?.name);
    }
}

public class SilverCustomer : customer
{

}

public class student
{

}