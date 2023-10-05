using CozaStore.ViewModels;

namespace CozaStore.Services;

public interface IHomeService
{
    Task<HomeVM> GetIndexData();
}