using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CozaStore.Models;
namespace CozaStore.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cor> Cores { get; set; }
    public DbSet<ListaDesejo> ListaDesejos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoAvaliacao> ProdutoAvaliacaos { get; set; }
    public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; }
    public DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }
    public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
    public DbSet<ProdutoTag> ProdutoTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Tamanho> Tamanhos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder) //void não tem retorno
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

        //FluentAPI
        #region Personalização do Identity
        // builder.Entity<IdentityUser>(b => {
        //     b.ToTable("IdentityUsers");
        // });
        // builder.Entity<IdentityUserClaim<string>>(b => {
        //     b.ToTable("IdentityUserClaims");
        // });
        // builder.Entity<IdentityUserLogin<string>>(b => {
        //     b.ToTable("IdentityUserLogins");
        // });
        // builder.Entity<IdentityUserToken<string>>(b => {
        //     b.ToTable("IdentityUserTokens");
        // });
        // builder.Entity<IdentityRole>(b => {
        //     b.ToTable("IdentityRoles");
        // });
        // builder.Entity<IdentityRoleClaim<string>>(b => {
        //     b.ToTable("IdentityRoleClaims");
        // });
        // builder.Entity<IdentityUserRole<string>>(b => {
        //     b.ToTable("IdentityUserRoles");
        // });
        #endregion
    
        #region Chave Primária Composta - ProdutoFoto
        builder.Entity<ProdutoFoto>().HasKey(
            pf => new { pf.Id, pf.ProdutoId }
        );
        #endregion

        #region Relacionamento Muitos para Muitos - ProdutoAvaliacao
        builder.Entity<ProdutoAvaliacao>().HasKey(
            pa => new { pa.ProdutoId, pa.UsuarioId }
        );
        
        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Produto)
            .WithMany(p => p.Avaliacoes)
            .HasForeignKey(pa => pa.ProdutoId);
        
        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Usuario)
            .WithMany(u => u.Avaliacoes)
            .HasForeignKey(pa => pa.UsuarioId);
        #endregion

        #region Relacionamento Muitos para Muitos - ProdutoCategoria
        builder.Entity<ProdutoCategoria>().HasKey(
            pc => new { pc.ProdutoId, pc.CategoriaId }
        );

        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Produto)
            .WithMany(p => p.Categorias)
            .HasForeignKey(pc => pc.ProdutoId);
        
        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Categoria)
            .WithMany(c => c.Produtos)
            .HasForeignKey(pc => pc.CategoriaId);
        #endregion

        #region Relacionamento Muitos para Muitos - ProdutoEstoque
        builder.Entity<ProdutoEstoque>()
            .HasOne(pe => pe.Produto)
            .WithMany(p => p.Estoque)
            .HasForeignKey(pe => pe.ProdutoId);
        
        builder.Entity<ProdutoEstoque>()
            .HasOne(pe => pe.Tamanho)
            .WithMany(t => t.Estoque)
            .HasForeignKey(pe => pe.TamanhoId);
        
        builder.Entity<ProdutoEstoque>()
            .HasOne(pe => pe.Cor)
            .WithMany(c => c.Estoque)
            .HasForeignKey(pe => pe.CorId);
        #endregion
    
        #region Relacionamento Muitos para Muitos - ProdutoTag
        builder.Entity<ProdutoTag>().HasKey(
            pt => new { pt.ProdutoId, pt.TagId }
        );

        builder.Entity<ProdutoTag>()
            .HasOne(pt => pt.Produto)
            .WithMany(p => p.Tags)
            .HasForeignKey(pt => pt.ProdutoId);
        
        builder.Entity<ProdutoTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.Produtos)
            .HasForeignKey(pt => pt.TagId);
        #endregion
    
        #region Relacionamento Muitos para Muitos - ListaDesejo
        builder.Entity<ListaDesejo>().HasKey(
            ld => new { ld.ProdutoId, ld.UsuarioId }
        );

        builder.Entity<ListaDesejo>()
            .HasOne(ld => ld.Produto)
            .WithMany(p => p.ListaDesejos)
            .HasForeignKey(ld => ld.ProdutoId);
        
        builder.Entity<ListaDesejo>()
            .HasOne(ld => ld.Usuario)
            .WithMany(u => u.ListaDesejos)
            .HasForeignKey(ld => ld.UsuarioId);
        #endregion

        #region Relacionamento Muitos para Muitos - CarrinhoProduto
        builder.Entity<CarrinhoProduto>().HasKey(
            cp => new { cp.CarrinhoId, cp.ProdutoEstoqueId }
        );

        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Carrinho)
            .WithMany(c => c.Produtos)
            .HasForeignKey(cp => cp.CarrinhoId);

        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.ProdutoEstoque)
            .WithMany(p => p.Carrinhos)
            .HasForeignKey(cp => cp.ProdutoEstoqueId);
        #endregion
    }
}
