namespace fin.DTOS;

public class AccountDTO
{
    public string Name { get; set; } = default!;

    public decimal Balance { get; set; }

    public string Category { get; set; }= default!;

    public string Icon { get; set; }= default!;
    // public ICollection<Transaction>? Transactions { get;set; }
}