using ApiEquipamento.Dominio.ModuloTeste.Enums;

namespace ApiEquipamento.Dominio.ModuloTeste;

public class Teste
{
    public Teste(int id, DateTime dataTeste, string nomeLead, string vendedorResponsavel, string operadorResponsavel, string telefoneLead, string equipamentoTestado, Resultado resultadoTeste, string linkLead, string observacao)
    {
        DataTeste = dataTeste;
        NomeLead = nomeLead;
        VendedorResponsavel = vendedorResponsavel;
        OperadorResponsavel = operadorResponsavel;
        TelefoneLead = telefoneLead;
        EquipamentoTestado = equipamentoTestado;
        ResultadoTeste = resultadoTeste;
        LinkLead = linkLead;
        Observacao = observacao;
    }

    public int Id { get; set; }
    public DateTime DataTeste { get; set; }
    public string NomeLead { get; set; }
    public string VendedorResponsavel { get; set; }
    public string OperadorResponsavel { get; set; }
    public string TelefoneLead { get; set; }
    public string EquipamentoTestado { get; set; }
    public Resultado ResultadoTeste { get; set; }
    public string LinkLead { get; set; }
    public string Observacao { get; set; }
}