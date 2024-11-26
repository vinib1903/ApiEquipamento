using ApiEquipamento.Dominio.ModuloGeral;
using ApiEquipamento.Dominio.ModuloGeral.Enums;
using ApiEquipamento.Repositorio.ModuloTeste;
using ApiEquipamento.Repositorio.ModuloTeste.ModuloGeral;
using Microsoft.EntityFrameworkCore;

namespace ApiEquipamento.Repositorio.ModuloGeral;

public class PessoaRepositorio : RepositorioBase<Pessoa>, IPessoaRepositorio
{
    private readonly AppDbContext _context;

    public PessoaRepositorio(AppDbContext context) : base(context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Pessoa>> ObterPorTipoPessoaAsync(TipoPessoa tipoPessoa)
    {
        return await _context.Pessoas
            .Where(p => p.TipoPessoa == tipoPessoa)
            .ToListAsync();
    }

}