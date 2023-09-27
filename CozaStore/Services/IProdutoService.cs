using CozaStore.ViewModels;

namespace CozaStore.Services;

public interface IProdutoService
{
    Task<List<ProdutoVM>> GetProduto();
}
