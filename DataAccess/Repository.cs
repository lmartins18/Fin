using fin.Models;
using Microsoft.EntityFrameworkCore;

namespace fin.DataAccess;
public class Repository<Entity> where Entity: BaseModel
    {
    private readonly FinContext _context;
    private DbSet<Entity> _dbSet;
    public Repository(FinContext context)
    {
        _context = context;
        _dbSet = _context.Set<Entity>();
    }

    public async Task<List<Entity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<Entity> GetAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task CreateAsync(Entity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(Entity entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(Entity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

}