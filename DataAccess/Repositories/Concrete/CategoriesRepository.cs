namespace fin.DataAccess.Repositories.Concrete;
public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
{
    public CategoriesRepository(FinContext context, ILogger logger) : base(context, logger)
    {
    }
}