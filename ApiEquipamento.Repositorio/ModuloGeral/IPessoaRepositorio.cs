using ApiEquipamento.Dominio.ModuloGeral;
using ApiEquipamento.Dominio.ModuloGeral.Enums;
using ApiEquipamento.Infra.Interfaces;

namespace ApiEquipamento.Repositorio.ModuloTeste.ModuloGeral;

public interface IPessoaRepositorio : IRepositorio<Pessoa>
{
    Task <IEnumerable<Pessoa>> ObterPorTipoPessoaAsync(TipoPessoa tipoPessoa);
}