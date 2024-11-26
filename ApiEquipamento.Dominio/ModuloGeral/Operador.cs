using ApiEquipamento.Dominio.ModuloGeral.Enums;

namespace ApiEquipamento.Dominio.ModuloGeral;

public class Operador : Pessoa
{
    public Operador (string nome) : base(nome, TipoPessoa.Operador) { }
}