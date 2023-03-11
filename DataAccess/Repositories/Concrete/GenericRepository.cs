using Microsoft.EntityFrameworkCore;

namespace fin.DataAccess.Repositories.Concrete;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    protected FinContext _context;
    protected DbSet<T> dbSet;
    protected readonly ILogger _logger;
    public GenericRepository(
        FinContext context,
        ILogger logger)
    {
        _context = context;
        _logger = logger;
        dbSet = _context.Set<T>();
    }

    public async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return true;
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return dbSet.Where(expression);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<T?> GetById(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public async Task<bool> Remove(Guid id)
    {
        var t = await dbSet.FindAsync(id);

        if (t != null)
        {
            dbSet.Remove(t);
            return true;
        }
        else return false;
    }

    public Task<bool> Upsert(T entity)
    {
        throw new NotImplementedException();
    }
}