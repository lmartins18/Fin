namespace fin.DataAccess.Repositories.Concrete;
public class IconsRepository : GenericRepository<Icon>, IIconsRepository
{
    public IconsRepository(FinContext context, ILogger logger) : base(context, logger)
    {
    }
}