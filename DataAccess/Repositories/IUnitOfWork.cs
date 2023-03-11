namespace fin.DataAccess.Repositories;
public interface IUnitOfWork : IDisposable
{
    IAccountsRepository Accounts { get; }
    Task<int> CompletedAsync();
}