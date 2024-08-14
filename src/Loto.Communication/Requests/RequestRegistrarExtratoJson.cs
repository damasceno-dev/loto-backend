namespace Loto.Communication.Requests;

public class RequestRegistrarExtratoJson
{
    public DateTime DataLancamento { get; set; }
    public decimal Valor { get; set; }
    public Guid ContaId { get; set; }
    public Guid ClassificacaoLancamentoId { get; set; }
}