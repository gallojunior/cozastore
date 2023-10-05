using CozaStore.Data;
using CozaStore.Models;
using CozaStore.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CozaStore.Services;

public class ProdutoService : IProdutoService
{
    private readonly AppDbContext _contexto;
    public ProdutoService(AppDbContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<List<ProdutoVM>> GetProdutos()
    {
        var produtos = await
            (from produto in _contexto.Produtos
            let categorias =
                (from prodCategoria in _contexto.ProdutoCategorias
                join categoria in _contexto.Categorias on prodCategoria.CategoriaId equals categoria.Id
                where prodCategoria.ProdutoId == produto.Id
                select categoria.Nome).ToList()
            let tags = 
                (from prodTag in _contexto.ProdutoTags
                join tag in _contexto.Tags on prodTag.TagId equals tag.Id
                where prodTag.ProdutoId == produto.Id
                select tag.Nome).ToList()
            let cores =
                (from prodEstoque in _contexto.ProdutoEstoques
                join cor in _contexto.Cores on prodEstoque.CorId equals cor.Id
                where prodEstoque.ProdutoId == produto.Id
                select cor.Nome).ToList()
            let tamanhos =
                (from prodEstoque in _contexto.ProdutoEstoques
                join tamanho in _contexto.Tamanhos on prodEstoque.TamanhoId equals tamanho.Id
                where prodEstoque.ProdutoId == produto.Id
                select string.Concat(tamanho.Sigla, " - ", tamanho.Nome)).ToList()
            let fotos =
                (from prodFoto in _contexto.ProdutoFotos
                where prodFoto.ProdutoId == produto.Id
                orderby prodFoto.Destaque
                select prodFoto.ArquivoFoto).ToList()
            select new ProdutoVM
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.DescricaoResumida,
                Preco = "R$ " + produto.Preco.ToString("N2"),
                Categorias = categorias,
                Tags = tags,
                Cores = cores,
                Tamanhos = tamanhos,
                Fotos = fotos
            }).ToListAsync();
        produtos.ForEach(p => p.Cores = p.Cores.Distinct().ToList());
        produtos.ForEach(p => p.Tamanhos = p.Tamanhos.Distinct().ToList());
        return produtos;
    }
}
