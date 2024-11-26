using ApiEquipamento.Dominio.ModuloTeste;
using ApiEquipamento.Dominio.ModuloTeste.Enums;
using ApiEquipamento.Infra.Interfaces;

namespace ApiEquipamento.Repositorio.ModuloTeste.ModuloTeste;

public interface ITesteRepositorio : IRepositorio<Teste>
{
    Task <IEnumerable<Teste>> ObterPorResultadoAsync(Resultado resultado);
}