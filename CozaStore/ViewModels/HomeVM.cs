using CozaStore.Models;
namespace CozaStore.ViewModels;

public class HomeVM
{
    public List<Categoria> Banners { get; set; }
    public List<Categoria> Categorias { get; set; }
    public List<Cor> Cores { get; set; }
    public List<Tag> Tags { get; set; }
    public List<ProdutoVM> Produtos { get; set; }
}
