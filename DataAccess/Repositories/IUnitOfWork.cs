namespace fin.DataAccess.Repositories;
public interface IUnitOfWork : IDisposable
{
    IAccountsRepository Accounts { get; }
    public IIconsRepository Icons { get; }
    public ITransactionsRepository Transactions { get; }
    public IGoalsRepository Goals { get; }
    public ICategoriesRepository Categories { get; }
    Task<int> CompletedAsync();
}