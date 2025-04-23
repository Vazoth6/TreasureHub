using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.InteropServices.JavaScript;

namespace TreasureHub.Models;

public class Utilizador
{
    [Key]
    public long UtilizadorId { get; set; }
    
    [Required]
    public string NomeUtilizador { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    public string Cargo { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    public DateTime DataRegisto { get; set; }
    
}