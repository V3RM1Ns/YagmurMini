using Microsoft.EntityFrameworkCore;
using Orm.Core.Entities.Common;
using Orm.DAL.DataStorage.Contexts;
using Orm.DAL.Repositories.Interfaces;

namespace Orm.DAL.Repositories.Concretes;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContex _context;
    public DbSet<TEntity> Table { get; set; }


    public Repository(AppDbContex context)
    {
        _context = context;
        Table = _context.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        _context.Remove(await Table.FindAsync(id));
    }

    public async Task UpdateAsync(int id)
    {
        _context.Update(await Table.FindAsync(id));
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await Table.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Table.ToListAsync();
    }
}