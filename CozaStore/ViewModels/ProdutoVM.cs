namespace CozaStore.ViewModels;

public class ProdutoVM
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Preco { get; set; }
    public List<string> Fotos { get; set; }
    public List<string> Tamanhos { get; set; }
    public List<string> Cores { get; set; }
    public List<string> Categorias { get; set; }
    public List<string> Tags { get; set; }
}
