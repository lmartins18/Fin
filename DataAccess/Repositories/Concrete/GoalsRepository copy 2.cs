namespace fin.DataAccess.Repositories.Concrete;
public class GoalsRepository : GenericRepository<Goal>, IGoalsRepository
{
    public GoalsRepository(FinContext context, ILogger logger) : base(context, logger)
    {
    }
}