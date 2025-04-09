using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreasureHub.Models;

public class Item
{
    [Key]
    public long ItemId { get; set; }
    
    public string Nome { get; set; }
    
    public string Descricao { get; set; }
    
    public string Imagem { get; set; }
    
    [ForeignKey("Categoria")]
    public long CategoriaID { get; set; }
    
    public Categoria Categoria { get; set; }
    
    [ForeignKey("Utilizador")]
    public string DonoId { get; set; }
    
    public Utilizador Dono { get; set; }
    
    public string DataLancamento { get; set; }  
    
    public bool isTroca { get; set; }
    
    public bool isVenda { get; set; }
    
    public ICollection<ListagemItem> Listagens { get; set; }
    
}