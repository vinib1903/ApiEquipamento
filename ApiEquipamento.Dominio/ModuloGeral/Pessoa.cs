using ApiEquipamento.Dominio.ModuloGeral.Enums;

namespace ApiEquipamento.Dominio.ModuloGeral;

public abstract class Pessoa
{
    protected Pessoa(string nome, TipoPessoa tipoPessoa)
    {
        Nome = nome;
        TipoPessoa = tipoPessoa;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public TipoPessoa TipoPessoa { get; protected set; }
}