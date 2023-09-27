using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CozaStore.Models;

[Table("CarrinhoProduto")]
public class CarrinhoProduto
{
    [Key, Column(Order = 1)]
    [Required]
    public int CarrinhoId { get; set; }
    [ForeignKey("CarrinhoId")]
    public Carrinho Carrinho { get; set; }

    [Key, Column(Order = 2)]
    [Required(ErrorMessage = "Informe o Produto")]
    public int ProdutoEstoqueId { get; set; }
    [ForeignKey("ProdutoEstoqueId")]
    public ProdutoEstoque ProdutoEstoque { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal Preco { get; set; } = 0;

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal PrecoDesconto { get; set; } = 0;

    [Display(Name = "Qtde em Estoque")]
    [Required(ErrorMessage = "Informe a Qtde em Estoque")]
    public int QtdeEstoque { get; set; } = 1;

}
