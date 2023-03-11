namespace fin.DataAccess;
public interface IUnitOfWork : IDisposable
{
    IAccountsRepository Accounts { get; }
    Task<int> CompletedAsync();
}