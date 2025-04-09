using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class Transacao
{
    [Key]
    public long TransacaoID { get; set; }

    [ForeignKey("Listagem")]
    public long ListagemID { get; set; }

    public ListagemItem Listagem { get; set; }

    [ForeignKey("Utilizador")]
    public long UtilizadorID { get; set; }

    public Utilizador Utilizador { get; set; }

    public string Listagem_nome { get; set; }

    public string Nome_utilizador { get; set; }

    public DateTime Data_Transacao { get; set; }

    public decimal Preco { get; set; }

    public bool isTroca { get; set; }
}