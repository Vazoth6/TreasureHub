using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class UtilizadorItem
{
    public int UtilizadorId { get; set; }
    public Utilizador Utilizador { get; set; }

    public int ItemId { get; set; }
    public Item Item { get; set; }

    public DateTime DataAquisicao { get; set; }
    public string Metodo { get; set; }
}