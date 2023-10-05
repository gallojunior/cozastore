using CozaStore.Data;
using CozaStore.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CozaStore.Services;

public class HomeService : IHomeService
{
    private readonly AppDbContext _contexto;
    private readonly IProdutoService _produtoService;

    public HomeService(AppDbContext contexto, IProdutoService produtoService)
    {
        _contexto = contexto;
        _produtoService = produtoService;
    }

    public async Task<HomeVM> GetIndexData()
    {
        HomeVM home = new() {
            Banners = await _contexto.Categorias.Where(c => c.Banner).ToListAsync(),
            Categorias = await _contexto.Categorias.Where(c => c.Filtrar).ToListAsync(),
            Cores = await _contexto.Cores.OrderBy(c => c.Id).ToListAsync(),
            Tags = await _contexto.Tags.ToListAsync(),
            Produtos = await _produtoService.GetProdutos()
        };
        return home;
    }
}