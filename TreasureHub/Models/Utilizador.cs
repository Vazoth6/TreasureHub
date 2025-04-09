using System.ComponentModel.DataAnnotations;

namespace TreasureHub.Models;

public class Utilizador
{
    [Key]
    public long utilizadorId { get; set; }
    
    [Required]
    public string nomeUtilizador { get; set; }
    
    [Required]
    public string email { get; set; }
    
    public string cargo { get; set; }
    
    public string password { get; set; }
    
    public DateTime dataRegisto { get; set; }
    
    public ICollection<Item> Itens { get; set; }
    public ICollection<ListagemItem> Listagens { get; set; }
    public ICollection<Transacao> Transacoes { get; set; }
}