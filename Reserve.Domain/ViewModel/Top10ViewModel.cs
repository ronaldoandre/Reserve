using System.ComponentModel.DataAnnotations;

namespace Reserve.Domain.ViewModels;
public class Top10ViewModel
{
    [Key]
    public int Posicao { get; set; }
    public string Nome { get; set; }
    public int Casos { get; set; }
}