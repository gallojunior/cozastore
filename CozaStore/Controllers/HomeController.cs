using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CozaStore.Models;
using CozaStore.Services;

namespace CozaStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProdutoService _produtoService;

    public HomeController(ILogger<HomeController> logger, IProdutoService produtoService)
    {
        _logger = logger;
        _produtoService = produtoService;
    }

    public async Task<IActionResult> Index()
    {
        var produtos = await _produtoService.GetProdutos();
        return View(produtos);
    }

    public IActionResult Loja()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }

    public IActionResult Blog()
    {
        return View();
    }

    public IActionResult Contatos()
    {
        return View();
    }

    public IActionResult Termos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
