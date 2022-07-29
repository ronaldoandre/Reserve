using Reserve.Domain.Models;

namespace Reserve.Domain.Interfaces;
public interface IRepository 
{
    Task<Consulta> GetAsync();
}
