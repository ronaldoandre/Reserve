using Reserve.Domain.Interfaces;
using Reserve.Domain.Models;

namespace Reserve.Data.Repository;
public class Repository : IRepository
{
    private const string listaPaisesUrl = "https://api.covid19api.com/summary";

    private static HttpClient _httpClient;
    private static HttpClient HttpClient => _httpClient ?? (_httpClient = new HttpClient());

    public Task<Consulta> GetAsync()
    {
        return this.GetDadosWebServiceAsync();
    }

    public async Task<Consulta> GetDadosWebServiceAsync()
    {
        HttpResponseMessage response = await HttpClient.GetAsync(listaPaisesUrl);
        if (response.IsSuccessStatusCode)
        {
            string responseBodyAsText = await response.Content.ReadAsStringAsync();
            Consulta result = new Consulta();
            result.Countries = responseBodyAsText;
            return  result;

        }
        return null;
    }
    
}
