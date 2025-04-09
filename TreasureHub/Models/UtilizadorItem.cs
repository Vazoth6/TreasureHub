using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class UtilizadorItem
{
    [Key]
    public long UtilizadorItemID { get; set; }

    [ForeignKey("Utilizador")]
    public long UtilizadorID { get; set; }

    public Utilizador Utilizador { get; set; }

    [ForeignKey("Item")]
    public long ItemID { get; set; }

    public Item Item { get; set; }

    public string NomeItem { get; set; }

    public string TipoPosse { get; set; }
}