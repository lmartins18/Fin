namespace fin.Models.Concrete;
public partial class Icon: BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
