using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class Transacao
{
    [Key]
    public int TransacaoId { get; set; }

    public int CompradorId { get; set; }
    public Utilizador Comprador { get; set; }

    public int VendedorId { get; set; }
    public Utilizador Vendedor { get; set; }

    public int ItemId { get; set; }
    public Item Item { get; set; }

    public DateTime Data { get; set; }
    
    public decimal Preco { get; set; }
    
    public string Estado { get; set; }
}