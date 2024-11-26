using ApiEquipamento.Dominio.ModuloTeste;
using ApiEquipamento.Infra.Interfaces;
using ApiEquipamento.Infra.Interfaces.ModuloTeste;

namespace ApiEquipamento.Aplicacao.ModuloTeste;

public class TesteService : ITesteService
{
    private readonly IRepositorio<Teste> _repositorio;

    public TesteService(IRepositorio<Teste> repositorio)
    {
        _repositorio = repositorio;
    }
    
    public async Task<IEnumerable<Teste>> RecuperarTodosAsync()
    {
        return await _repositorio.ObterTodosAsync();
    }

    public async Task<Teste?> RecuperarPorIdAsync(int id)
    {
        return await _repositorio.ObterPorIdAsync(id);
    }

    public async Task InserirAsync(Teste teste)
    {
        await _repositorio.AdicionarAsync(teste);
    }

    public async Task AtualizarAsync(Teste teste)
    {
        await _repositorio.AtualizarAsync(teste);
    }

    public async Task ExcluirAsync(int id)
    {
        await _repositorio.RemoverAsync(id);
    }
}

