namespace Reserve.Domain.Models;
public class Paises
{
    public int Id { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string Confirmed { get; set; }
    public string Deaths { get; set; }
    public string Recovered { get; set; }
    public string Active { get; set; }
    public DateTime Date { get; set; }
    public string LocationId { get; set; }
}
