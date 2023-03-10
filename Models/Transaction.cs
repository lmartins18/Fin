namespace fin.Models.Concrete;
public partial class Transaction: BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Amount { get; set; }

    public int? AccountId { get; set; }

    public bool? Credit { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Category? Category { get; set; }
}
