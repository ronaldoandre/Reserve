using Reserve.Domain.Interfaces;
using Reserve.Domain.Models;

namespace Reserve.Service.Service;
public class CovidService : IService
{

    private readonly IRepository _repository;
    public CovidService(IRepository repository)
    {
        _repository = repository;
    }
    public async Task<Consulta> Get()
    {
        return await _repository.GetAsync();
    }
}
