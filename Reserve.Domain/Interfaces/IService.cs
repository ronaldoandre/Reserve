using Reserve.Domain.Models;

namespace Reserve.Domain.Interfaces;
public interface IService 
{
    Task<Consulta> Get();
}
