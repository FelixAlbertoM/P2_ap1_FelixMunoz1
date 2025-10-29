using System.ComponentModel.DataAnnotations;

namespace P2_ap1_FelixMunoz.Models;

public class Registro
{
    [Key]
    public int IdRegistro { get; set; }


    [Required(ErrorMessage = "Por favor digitar la fecha.")]
    public DateTime Fecha { get; set; } = DateTime.Now;
}