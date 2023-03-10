namespace fin.Models.Concrete;

public partial class Account: BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Balance { get; set; }

    public int? CategoryId { get; set; }

    public int? Icon { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Icon? IconNavigation { get; set; }

    public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
}
