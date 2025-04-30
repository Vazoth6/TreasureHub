using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    public string Nome { get; set; }
    
    // Url da imagem
    public string Imagem { get; set; }
    public string Descricao { get; set; }

    public int CategoriaId { get; set; } 
    public Categoria Categoria { get; set; }

    public double Preco { get; set; }
    
    public string Estado { get; set; }
    
}