using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CozaStore.Models;

namespace CozaStore.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Cor
        List<Cor> cores = new() {
            new Cor() {
                Id = 1,
                Nome = "Preto",
                CodigoHexa = "#222"
            },
            new Cor() {
                Id = 2,
                Nome = "Azul",
                CodigoHexa = "#4272d7"
            },
            new Cor() {
                Id = 3,
                Nome = "Cinza",
                CodigoHexa = "#b3b3b3"
            },
            new Cor() {
                Id = 4,
                Nome = "Verde",
                CodigoHexa = "#00ad5f"
            },
            new Cor() {
                Id = 5,
                Nome = "Vermelho",
                CodigoHexa = "#fa4251"
            },
            new Cor() {
                Id = 6,
                Nome = "Branco",
                CodigoHexa = "#aaa"
            }
        };
        builder.Entity<Cor>().HasData(cores);
        #endregion

        #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Nome = "Feminina",
                Foto = @"images/categorias/1.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Masculina",
                Foto = @"images/categorias/2.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Acessórios",
                Foto = @"images/categorias/3.jpg",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Bolsas",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 5,
                Nome = "Calçados",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 6,
                Nome = "Relógios",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Tag
        List<Tag> tags = new() {
            new Tag() {
                Id = 1,
                Nome = "Fashion"
            },
            new Tag() {
                Id = 2,
                Nome = "LifeStyle"
            },
            new Tag() {
                Id = 3,
                Nome = "Denim"
            },
            new Tag() {
                Id = 4,
                Nome = "StreetStyle"
            },new Tag() {
                Id = 5,
                Nome = "Crafts"
            }
        };
        builder.Entity<Tag>().HasData(tags);
        #endregion

        #region Populate Tamanho
        List<Tamanho> tamanhos = new() {
            new Tamanho() {
                Id = 1,
                Sigla = "P",
                Nome = "Pequeno"
            },
            new Tamanho() {
                Id = 2,
                Sigla = "M",
                Nome = "Médio"
            },
            new Tamanho() {
                Id = 3,
                Sigla = "G",
                Nome = "Grande"
            },
            new Tamanho() {
                Id = 4,
                Sigla = "GG",
                Nome = "Extra Grande"
            }
        };
        builder.Entity<Tamanho>().HasData(tamanhos);
        #endregion

        #region Populate Produtos
        List<Produto> produtos = new() {
            new Produto() {
                Id = 1,
                Nome = "Camiseta Esprit Ruffle",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 20.64M,
                PrecoDesconto = 20.64M,
                SKU = "CAM-01",
                Destaque = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);
        
        List<ProdutoCategoria> produtoCategorias = new() {
            new ProdutoCategoria() {
                ProdutoId = 1,
                CategoriaId = 1
            }
        };
        builder.Entity<ProdutoCategoria>().HasData(produtoCategorias);

        List<ProdutoTag> produtoTags = new() {
            new ProdutoTag() {
                ProdutoId = 1,
                TagId = 1
            }
        };
        builder.Entity<ProdutoTag>().HasData(produtoTags);

        List<ProdutoFoto> produtoFotos = new() {
            new ProdutoFoto() {
                Id = 1,
                ProdutoId = 1,
                ArquivoFoto = @"/images/produtos/1/1.jpg",
                Destaque = true
            }
        };
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);

        List<ProdutoEstoque> produtoEstoque = new() {
            new ProdutoEstoque() {
                Id = 1,
                ProdutoId = 1,
                CorId = 6,
                TamanhoId = 1,
                QtdeEstoque = 10
            },
            new ProdutoEstoque() {
                Id = 2,
                ProdutoId = 1,
                CorId = 6,
                TamanhoId = 2,
                QtdeEstoque = 10
            },
            new ProdutoEstoque() {
                Id = 3,
                ProdutoId = 1,
                CorId = 6,
                TamanhoId = 3,
                QtdeEstoque = 10
            },
        };
        builder.Entity<ProdutoEstoque>().HasData(produtoEstoque);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Funcionário",
               NormalizedName = "FUNCIONARIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "gallojunior@gmail.com",
                NormalizedEmail = "GALLOJUNIOR@GMAIL.COM",
                UserName = "GalloJunior",
                NormalizedUserName = "GALLOJUNIOR",
                LockoutEnabled = false,
                PhoneNumber = "14912345678",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "José Antonio Gallo Junior",
                DataNascimento = DateTime.Parse("05/08/1981"),
                Foto = "/img/users/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}