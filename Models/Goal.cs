namespace fin.Models.Concrete;

public partial class Goal: BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? AmountAchieved { get; set; }

    public decimal? AmountToAchieve { get; set; }
}
