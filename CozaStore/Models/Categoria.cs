using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CozaStore.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [StringLength(300)]
    [Display(Name = "Foto de Capa")]
    public string Foto { get; set; }

    [Display(Name = "Exibir para Filtro?")]
    public bool Filtrar { get; set; }
    
    [Display(Name = "Exibir como Banner?")]
    public bool Banner { get; set; }

    public byte? CategoriaPaiId { get; set; }
    [ForeignKey("CategoriaPaiId")]
    public Categoria CategoriaPai { get; set; }

    public ICollection<ProdutoCategoria> Produtos { get; set; }
}
