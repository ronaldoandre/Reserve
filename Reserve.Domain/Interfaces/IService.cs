using Reserve.Domain.Models;
using Reserve.Domain.ViewModels;

namespace Reserve.Domain.Interfaces;
public interface IService 
{
    Task<List<Top10ViewModel>> Get();
}
