using fin.Models.Concrete;

namespace fin.DataAccess.Concrete;
public class AccountsRepository : Repository<Account>
{
    public AccountsRepository(FinContext context) : base(context)
    {
    }
    public IEnumerable<AccountsRepository> GetAll()
    => this.GetAll();
}