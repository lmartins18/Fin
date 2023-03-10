namespace fin.Models.Concrete;

public partial class Category: BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
}
