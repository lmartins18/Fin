namespace fin.DataAccess.Repositories.Concrete;
public class AccountsRepository : GenericRepository<Account>, IAccountsRepository
{
    public AccountsRepository(FinContext context, ILogger logger) : base(context, logger)
    {
    }
}