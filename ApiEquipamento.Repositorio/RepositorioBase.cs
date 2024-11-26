using ApiEquipamento.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiEquipamento.Repositorio.ModuloTeste;

public class RepositorioBase<T> : IRepositorio<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public RepositorioBase(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> ObterTodosAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> ObterPorIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> ObterPorFiltrosAsync(Func<T, bool> filtro)
    {
        return await Task.FromResult(_dbSet.Where(filtro).ToList());
    }

    public async Task AdicionarAsync(T entidade)
    {
        await _dbSet.AddAsync(entidade);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(T entidade)
    {
        _dbSet.Update(entidade);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var entidade = await ObterPorIdAsync(id);
        if (entidade != null)
        {
            _dbSet.Remove(entidade);
            await _context.SaveChangesAsync();
        }
    }
}