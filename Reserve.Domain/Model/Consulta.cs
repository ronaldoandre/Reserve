namespace Reserve.Domain.Models;
public class Consulta
{
    public Guid ID { get; set; }

    public List<Paises> Countries { get; set; }
    public DateTime Date { get; set; }
}