using ApiEquipamento.Dominio.ModuloTeste;
using ApiEquipamento.Dominio.ModuloTeste.Enums;
using ApiEquipamento.Repositorio.ModuloTeste.ModuloTeste;
using Microsoft.EntityFrameworkCore;

namespace ApiEquipamento.Repositorio.ModuloTeste;

public class TesteRepositorio : RepositorioBase<Teste>, ITesteRepositorio
{
    private readonly AppDbContext _context;
    
    public TesteRepositorio(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Teste>> ObterPorResultadoAsync(Resultado resultado)
    {
        return await _context.Testes
            .Where(t => t.ResultadoTeste == resultado)
            .ToListAsync();
    }
}