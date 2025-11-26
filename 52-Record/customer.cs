public record customer
{
    public string firstname {  get; set; }
    public string lastname { get; set; }

}

public record SilverCustomer : customer
{
    public string email { get; set; }
}