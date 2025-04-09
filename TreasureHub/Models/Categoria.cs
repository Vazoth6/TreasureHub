using System.ComponentModel.DataAnnotations;

namespace TreasureHub.Models;

public class Categoria
{
    [Key]
    public long CategoriaId { get; set; }
    
    public string Nome { get; set; }
    
    public ICollection<Item> Itens { get; set; }
}