using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class ListagemItem
{
    [Key]
    public long ListagemID { get; set; }

    [ForeignKey("Item")]
    public long ItemID { get; set; }

    public Item Item { get; set; }

    [ForeignKey("Utilizador")]
    public long UtilizadorID { get; set; }

    public Utilizador Utilizador { get; set; }

    public string ItemNome { get; set; }

    public decimal Preco { get; set; }

    public bool isDisponivel { get; set; }

    public DateTime DataCriacao { get; set; }

    public bool isVendido { get; set; }
}