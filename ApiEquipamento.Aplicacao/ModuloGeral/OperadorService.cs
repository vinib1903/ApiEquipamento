using ApiEquipamento.Dominio.ModuloGeral;
using ApiEquipamento.Dominio.ModuloGeral.Enums;
using ApiEquipamento.Infra.Interfaces;

namespace ApiEquipamento.Aplicacao.ModuloGeral;

public class OperadorService : IBaseService<Operador>
{
    private readonly IRepositorio<Operador> _repositorio;

    public OperadorService(IRepositorio<Operador> repositorio)
    {
        _repositorio = repositorio;
    }
    
    public async Task<IEnumerable<Operador>> RecuperarTodosAsync()
    {
        return await _repositorio.ObterTodosAsync();
    }

    public async Task<Operador?> RecuperarPorIdAsync(int id)
    {
        return await _repositorio.ObterPorIdAsync(id);
    }

    public async Task InserirAsync(Operador operador)
    {
        await _repositorio.AdicionarAsync(operador);
    }

    public async Task AtualizarAsync(Operador operador)
    {
        await _repositorio.AtualizarAsync(operador);
    }

    public async Task ExcluirAsync(int id)
    {
        await _repositorio.RemoverAsync(id);
    }
    
}