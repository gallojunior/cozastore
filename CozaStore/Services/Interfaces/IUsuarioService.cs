using CozaStore.ViewModels.Account;

namespace CozaStore.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}
