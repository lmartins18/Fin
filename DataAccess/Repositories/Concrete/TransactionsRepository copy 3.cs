namespace fin.DataAccess.Repositories.Concrete;
public class TransactionsRepository : GenericRepository<Transaction>, ITransactionsRepository
{
    public TransactionsRepository(FinContext context, ILogger logger) : base(context, logger)
    {
    }
}