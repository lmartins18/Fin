namespace fin.DataAccess.Repositories.Concrete;
public class UnitOfWork : IUnitOfWork
{
    private readonly FinContext _context;
    private readonly ILogger _logger;
    public IAccountsRepository Accounts { get; private set; }

    public UnitOfWork(FinContext context, ILoggerFactory logger)
    {
        _context = context;
        _logger = logger.CreateLogger("logs");

        Accounts = new AccountsRepository(_context, _logger);
    }

    public async Task<int> CompletedAsync() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();
}