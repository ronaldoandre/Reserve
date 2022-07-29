using Reserve.Domain.Interfaces;
using Reserve.Domain.Models;
using Reserve.Domain.ViewModels;

namespace Reserve.Service.Service;
public class CovidService : IService
{

    private readonly IRepository _repository;
    public CovidService(IRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<Top10ViewModel>> Get()
    {
        var dados = await _repository.GetAsync();
        dados.Countries = dados.Countries.OrderByDescending(a => a.TotalConfirmed - (a.TotalRecovered + a.TotalDeaths)).Take(10).ToList();
        var result = new List<Top10ViewModel>();
        for(int i = 0; i < dados.Countries.Count(); i++)
        {
            var add = new Top10ViewModel();
            add.Casos = dados.Countries[i].TotalConfirmed - (dados.Countries[i].TotalRecovered + dados.Countries[i].TotalDeaths);
            add.Nome = dados.Countries[i].Country;
            add.Posicao = i+1;
            result.Add(add);
        }
        result = result.OrderByDescending(a => a.Casos).ToList();


        return result;
    }
}
