public class customer
{
    public string firstname;
    public string lastname;

    public customer (string fn, string ln)
    {
        firstname = fn;
        lastname = ln;
    }

    public override string ToString()
    {
        return firstname + " " + lastname;
    }

    public override bool Equals(object? obj)
    {
        customer c = (customer)obj;

        return this.firstname.Equals(c.firstname) &&
            this.lastname.Equals(c.lastname);
    }

    public override int GetHashCode()
    {
        return this.firstname.GetHashCode() ^ 
            this.lastname.GetHashCode();
    }
}