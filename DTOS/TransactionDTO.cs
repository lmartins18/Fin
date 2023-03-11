namespace fin.DTOS;
public class TransactionDto
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public bool Credit { get; set; }
    public string CategoryName { get; set; }
    public DateTime Date { get; set; }
}