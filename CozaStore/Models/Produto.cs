using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CozaStore.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(300, ErrorMessage = "A Descrição Resumida deve possuir no máximo 300 caracteres")]
    public string DescricaoResumida { get; set; }

    [Display(Name = "Descrição Completa")]
    [StringLength(8000)]
    public string DescricaoCompleta { get; set; }

    [Display(Name = "SKU")]
    [StringLength(10, ErrorMessage = "O SKU deve possuir no máximo 10 caracteres")]
    public string SKU { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal Preco { get; set; } = 0;

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal PrecoDesconto { get; set; } = 0;

    [Display(Name = "Produto em Destaque?")]
    public bool Destaque { get; set; } = false;

    [Column(TypeName = "decimal(6,3)")]
    public decimal Peso { get; set; } = 0;

    [StringLength(30, ErrorMessage = "O Material deve possuir no máximo 30 caracteres")]
    public string Material { get; set; }

    [StringLength(20, ErrorMessage = "O Material deve possuir no máximo 20 caracteres")]
    public string Dimensao { get; set; }

    public ICollection<ProdutoAvaliacao> Avaliacoes { get; set; }
    public ICollection<ProdutoCategoria> Categorias { get; set; }
    public ICollection<ProdutoEstoque> Estoque { get; set; }
    public ICollection<ProdutoFoto> Fotos { get; set; }
    public ICollection<ProdutoTag> Tags { get; set; }
    public ICollection<ListaDesejo> ListaDesejos { get; set; }
    
}
