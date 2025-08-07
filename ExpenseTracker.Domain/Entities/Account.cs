public class Account : BaseEntity
{
    public required string Name { get; set; }
    public decimal Balance { get; set; }

    public Account() : base()
    {
    }
}