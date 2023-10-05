using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CozaStore.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filtrar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Banner = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CategoriaPaiId = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Categoria_CategoriaPaiId",
                        column: x => x.CategoriaPaiId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoHexa = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoResumida = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoCompleta = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SKU = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrecoDesconto = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    Material = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dimensao = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tamanho",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanho", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoCategoria",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategoria", x => new { x.ProdutoId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoFoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ArquivoFoto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoFoto", x => new { x.Id, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ProdutoFoto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoTag",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoTag", x => new { x.ProdutoId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProdutoTag_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    TamanhoId = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    CorId = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    PrecoDesconto = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    QtdeEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Cor_CorId",
                        column: x => x.CorId,
                        principalTable: "Cor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Tamanho_TamanhoId",
                        column: x => x.TamanhoId,
                        principalTable: "Tamanho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Texto = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blog_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataModificacao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinho_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrinho_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListaDesejo",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDesejo", x => new { x.ProdutoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_ListaDesejo_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListaDesejo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoAvaliacao",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoTexto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProdutoNota = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAvaliacao", x => new { x.ProdutoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarrinhoProduto",
                columns: table => new
                {
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoEstoqueId = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrecoDesconto = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    QtdeEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProduto", x => new { x.CarrinhoId, x.ProdutoEstoqueId });
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Carrinho_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_ProdutoEstoque_ProdutoEstoqueId",
                        column: x => x.ProdutoEstoqueId,
                        principalTable: "ProdutoEstoque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29625af0-ab72-4124-8284-312d76b2f9b7", "f0545117-6db2-45ec-9a24-a87f4e8dcd85", "Cliente", "CLIENTE" },
                    { "7c814840-ed7b-4a9d-b162-fb7947ad1ff8", "cd77f02b-4928-4e69-87eb-db10ef0fd411", "Funcionário", "FUNCIONARIO" },
                    { "bb865f53-4805-4fc6-8900-d5c66a0b2016", "704f692f-4080-4df2-a91c-7cf0d0f1abf8", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ff54731-834c-46c5-9e68-a6a0aae5e796", 0, "e20415ef-716c-4b16-9f13-a17478dd59ac", "gallojunior@gmail.com", true, false, null, "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAEF2Txj4AlrUVgWXWvG+/daJ7S8F0/P8jCdOBsDrO0GeduDMOsVTq80xtYr9gqCGgDw==", "14912345678", true, "ec354784-df16-4296-aecd-9fac33fca542", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Banner", "CategoriaPaiId", "Filtrar", "Foto", "Nome" },
                values: new object[,]
                {
                    { (byte)1, true, null, true, "images/categorias/1.jpg", "Feminina" },
                    { (byte)2, true, null, true, "images/categorias/2.jpg", "Masculina" },
                    { (byte)3, true, null, false, "images/categorias/3.jpg", "Acessórios" }
                });

            migrationBuilder.InsertData(
                table: "Cor",
                columns: new[] { "Id", "CodigoHexa", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "#222", "Preto" },
                    { (byte)2, "#4272d7", "Azul" },
                    { (byte)3, "#b3b3b3", "Cinza" },
                    { (byte)4, "#00ad5f", "Verde" },
                    { (byte)5, "#fa4251", "Vermelho" },
                    { (byte)6, "#aaa", "Branco" }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "DescricaoCompleta", "DescricaoResumida", "Destaque", "Dimensao", "Material", "Nome", "Peso", "Preco", "PrecoDesconto", "SKU" },
                values: new object[,]
                {
                    { 1, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Camiseta Esprit Ruffle", 0m, 20.64m, 20.64m, "CAM-01" },
                    { 2, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Camiseta Herschel supply", 0m, 35.31m, 35.31m, "CAM-02" },
                    { 3, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Camiseta Quadriculada", 0m, 25.50m, 25.50m, "CAM-03" },
                    { 4, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Casaco Classic Trench", 0m, 75.25m, 75.25m, "CAS-01" },
                    { 5, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Lightweight Jacket", 0m, 53.0m, 53.0m, "COJ-01" },
                    { 6, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Femme T-Shirt In Stripe", 0m, 25.85m, 25.85m, "CAM-06" },
                    { 7, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Camiseta Herschel supply", 0m, 63.16m, 63.16m, "CAM-09" },
                    { 8, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Camiseta T-Shirt with Sleeve", 0m, 18.49m, 18.49m, "CAM-14" },
                    { 9, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Relógio Vintage Classic", 0m, 93.20m, 93.20m, "REL-01" },
                    { 10, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Tênis All Star Hi Plimsolls", 0m, 75.0m, 75.0m, "CAL-09" },
                    { 11, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Cinto de Couro", 0m, 63.15m, 63.15m, "CIN-04" },
                    { 12, "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.", "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat", true, null, null, "Mini Silver Mesh Watch", 0m, 86.85m, 86.85m, "REL-04" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "Fashion" },
                    { (byte)2, "LifeStyle" },
                    { (byte)3, "Denim" },
                    { (byte)4, "StreetStyle" },
                    { (byte)5, "Crafts" }
                });

            migrationBuilder.InsertData(
                table: "Tamanho",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[,]
                {
                    { (byte)1, "Pequeno", "P" },
                    { (byte)2, "Médio", "M" },
                    { (byte)3, "Grande", "G" },
                    { (byte)4, "Extra Grande", "GG" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "29625af0-ab72-4124-8284-312d76b2f9b7", "2ff54731-834c-46c5-9e68-a6a0aae5e796" },
                    { "7c814840-ed7b-4a9d-b162-fb7947ad1ff8", "2ff54731-834c-46c5-9e68-a6a0aae5e796" },
                    { "bb865f53-4805-4fc6-8900-d5c66a0b2016", "2ff54731-834c-46c5-9e68-a6a0aae5e796" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Banner", "CategoriaPaiId", "Filtrar", "Foto", "Nome" },
                values: new object[,]
                {
                    { (byte)4, false, (byte)3, true, "", "Bolsas" },
                    { (byte)5, false, (byte)3, true, "", "Calçados" },
                    { (byte)6, false, (byte)3, true, "", "Relógios" }
                });

            migrationBuilder.InsertData(
                table: "ProdutoCategoria",
                columns: new[] { "CategoriaId", "ProdutoId" },
                values: new object[,]
                {
                    { (byte)1, 1 },
                    { (byte)1, 2 },
                    { (byte)2, 3 },
                    { (byte)1, 4 },
                    { (byte)2, 5 },
                    { (byte)1, 6 },
                    { (byte)2, 7 },
                    { (byte)1, 8 },
                    { (byte)3, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoEstoque",
                columns: new[] { "Id", "CorId", "Preco", "PrecoDesconto", "ProdutoId", "QtdeEstoque", "TamanhoId" },
                values: new object[,]
                {
                    { 1, (byte)1, null, null, 1, 8, (byte)1 },
                    { 2, (byte)1, null, null, 1, 20, (byte)2 },
                    { 3, (byte)1, null, null, 1, 35, (byte)3 },
                    { 4, (byte)1, null, null, 1, 26, (byte)4 },
                    { 5, (byte)2, null, null, 1, 7, (byte)1 },
                    { 6, (byte)2, null, null, 1, 15, (byte)2 },
                    { 7, (byte)2, null, null, 1, 12, (byte)3 },
                    { 8, (byte)2, null, null, 1, 14, (byte)4 },
                    { 9, (byte)3, null, null, 1, 14, (byte)1 },
                    { 10, (byte)3, null, null, 1, 6, (byte)2 },
                    { 11, (byte)3, null, null, 1, 25, (byte)3 },
                    { 12, (byte)3, null, null, 1, 17, (byte)4 },
                    { 13, (byte)4, null, null, 1, 4, (byte)1 },
                    { 14, (byte)4, null, null, 1, 14, (byte)2 },
                    { 15, (byte)4, null, null, 1, 49, (byte)3 },
                    { 16, (byte)4, null, null, 1, 30, (byte)4 },
                    { 17, (byte)5, null, null, 1, 18, (byte)1 },
                    { 18, (byte)5, null, null, 1, 22, (byte)2 },
                    { 19, (byte)5, null, null, 1, 23, (byte)3 },
                    { 20, (byte)5, null, null, 1, 12, (byte)4 },
                    { 21, (byte)6, null, null, 1, 7, (byte)1 },
                    { 22, (byte)6, null, null, 1, 47, (byte)2 },
                    { 23, (byte)6, null, null, 1, 40, (byte)3 },
                    { 24, (byte)6, null, null, 1, 44, (byte)4 },
                    { 25, (byte)1, null, null, 2, 15, (byte)1 },
                    { 26, (byte)1, null, null, 2, 44, (byte)2 },
                    { 27, (byte)1, null, null, 2, 11, (byte)3 },
                    { 28, (byte)1, null, null, 2, 38, (byte)4 },
                    { 29, (byte)2, null, null, 2, 38, (byte)1 },
                    { 30, (byte)2, null, null, 2, 26, (byte)2 },
                    { 31, (byte)2, null, null, 2, 32, (byte)3 },
                    { 32, (byte)2, null, null, 2, 7, (byte)4 },
                    { 33, (byte)3, null, null, 2, 22, (byte)1 },
                    { 34, (byte)3, null, null, 2, 43, (byte)2 },
                    { 35, (byte)3, null, null, 2, 42, (byte)3 },
                    { 36, (byte)3, null, null, 2, 26, (byte)4 },
                    { 37, (byte)4, null, null, 2, 43, (byte)1 },
                    { 38, (byte)4, null, null, 2, 22, (byte)2 },
                    { 39, (byte)4, null, null, 2, 7, (byte)3 },
                    { 40, (byte)4, null, null, 2, 32, (byte)4 },
                    { 41, (byte)5, null, null, 2, 19, (byte)1 },
                    { 42, (byte)5, null, null, 2, 31, (byte)2 },
                    { 43, (byte)5, null, null, 2, 9, (byte)3 },
                    { 44, (byte)5, null, null, 2, 15, (byte)4 },
                    { 45, (byte)6, null, null, 2, 29, (byte)1 },
                    { 46, (byte)6, null, null, 2, 7, (byte)2 },
                    { 47, (byte)6, null, null, 2, 34, (byte)3 },
                    { 48, (byte)6, null, null, 2, 30, (byte)4 },
                    { 49, (byte)1, null, null, 3, 46, (byte)1 },
                    { 50, (byte)1, null, null, 3, 0, (byte)2 },
                    { 51, (byte)1, null, null, 3, 30, (byte)3 },
                    { 52, (byte)1, null, null, 3, 29, (byte)4 },
                    { 53, (byte)2, null, null, 3, 7, (byte)1 },
                    { 54, (byte)2, null, null, 3, 23, (byte)2 },
                    { 55, (byte)2, null, null, 3, 40, (byte)3 },
                    { 56, (byte)2, null, null, 3, 34, (byte)4 },
                    { 57, (byte)3, null, null, 3, 3, (byte)1 },
                    { 58, (byte)3, null, null, 3, 24, (byte)2 },
                    { 59, (byte)3, null, null, 3, 42, (byte)3 },
                    { 60, (byte)3, null, null, 3, 12, (byte)4 },
                    { 61, (byte)4, null, null, 3, 31, (byte)1 },
                    { 62, (byte)4, null, null, 3, 19, (byte)2 },
                    { 63, (byte)4, null, null, 3, 44, (byte)3 },
                    { 64, (byte)4, null, null, 3, 14, (byte)4 },
                    { 65, (byte)5, null, null, 3, 24, (byte)1 },
                    { 66, (byte)5, null, null, 3, 10, (byte)2 },
                    { 67, (byte)5, null, null, 3, 29, (byte)3 },
                    { 68, (byte)5, null, null, 3, 21, (byte)4 },
                    { 69, (byte)6, null, null, 3, 8, (byte)1 },
                    { 70, (byte)6, null, null, 3, 30, (byte)2 },
                    { 71, (byte)6, null, null, 3, 36, (byte)3 },
                    { 72, (byte)6, null, null, 3, 46, (byte)4 },
                    { 73, (byte)1, null, null, 4, 49, (byte)1 },
                    { 74, (byte)1, null, null, 4, 8, (byte)2 },
                    { 75, (byte)1, null, null, 4, 23, (byte)3 },
                    { 76, (byte)1, null, null, 4, 31, (byte)4 },
                    { 77, (byte)2, null, null, 4, 33, (byte)1 },
                    { 78, (byte)2, null, null, 4, 11, (byte)2 },
                    { 79, (byte)2, null, null, 4, 2, (byte)3 },
                    { 80, (byte)2, null, null, 4, 27, (byte)4 },
                    { 81, (byte)3, null, null, 4, 18, (byte)1 },
                    { 82, (byte)3, null, null, 4, 49, (byte)2 },
                    { 83, (byte)3, null, null, 4, 35, (byte)3 },
                    { 84, (byte)3, null, null, 4, 22, (byte)4 },
                    { 85, (byte)4, null, null, 4, 30, (byte)1 },
                    { 86, (byte)4, null, null, 4, 0, (byte)2 },
                    { 87, (byte)4, null, null, 4, 38, (byte)3 },
                    { 88, (byte)4, null, null, 4, 34, (byte)4 },
                    { 89, (byte)5, null, null, 4, 35, (byte)1 },
                    { 90, (byte)5, null, null, 4, 22, (byte)2 },
                    { 91, (byte)5, null, null, 4, 0, (byte)3 },
                    { 92, (byte)5, null, null, 4, 0, (byte)4 },
                    { 93, (byte)6, null, null, 4, 18, (byte)1 },
                    { 94, (byte)6, null, null, 4, 43, (byte)2 },
                    { 95, (byte)6, null, null, 4, 38, (byte)3 },
                    { 96, (byte)6, null, null, 4, 48, (byte)4 },
                    { 97, (byte)1, null, null, 5, 24, (byte)1 },
                    { 98, (byte)1, null, null, 5, 6, (byte)2 },
                    { 99, (byte)1, null, null, 5, 24, (byte)3 },
                    { 100, (byte)1, null, null, 5, 18, (byte)4 },
                    { 101, (byte)2, null, null, 5, 11, (byte)1 },
                    { 102, (byte)2, null, null, 5, 2, (byte)2 },
                    { 103, (byte)2, null, null, 5, 47, (byte)3 },
                    { 104, (byte)2, null, null, 5, 9, (byte)4 },
                    { 105, (byte)3, null, null, 5, 41, (byte)1 },
                    { 106, (byte)3, null, null, 5, 16, (byte)2 },
                    { 107, (byte)3, null, null, 5, 41, (byte)3 },
                    { 108, (byte)3, null, null, 5, 27, (byte)4 },
                    { 109, (byte)4, null, null, 5, 27, (byte)1 },
                    { 110, (byte)4, null, null, 5, 4, (byte)2 },
                    { 111, (byte)4, null, null, 5, 35, (byte)3 },
                    { 112, (byte)4, null, null, 5, 21, (byte)4 },
                    { 113, (byte)5, null, null, 5, 29, (byte)1 },
                    { 114, (byte)5, null, null, 5, 24, (byte)2 },
                    { 115, (byte)5, null, null, 5, 20, (byte)3 },
                    { 116, (byte)5, null, null, 5, 18, (byte)4 },
                    { 117, (byte)6, null, null, 5, 38, (byte)1 },
                    { 118, (byte)6, null, null, 5, 9, (byte)2 },
                    { 119, (byte)6, null, null, 5, 4, (byte)3 },
                    { 120, (byte)6, null, null, 5, 30, (byte)4 },
                    { 121, (byte)1, null, null, 6, 11, (byte)1 },
                    { 122, (byte)1, null, null, 6, 8, (byte)2 },
                    { 123, (byte)1, null, null, 6, 48, (byte)3 },
                    { 124, (byte)1, null, null, 6, 42, (byte)4 },
                    { 125, (byte)2, null, null, 6, 29, (byte)1 },
                    { 126, (byte)2, null, null, 6, 45, (byte)2 },
                    { 127, (byte)2, null, null, 6, 30, (byte)3 },
                    { 128, (byte)2, null, null, 6, 16, (byte)4 },
                    { 129, (byte)3, null, null, 6, 40, (byte)1 },
                    { 130, (byte)3, null, null, 6, 41, (byte)2 },
                    { 131, (byte)3, null, null, 6, 25, (byte)3 },
                    { 132, (byte)3, null, null, 6, 38, (byte)4 },
                    { 133, (byte)4, null, null, 6, 47, (byte)1 },
                    { 134, (byte)4, null, null, 6, 49, (byte)2 },
                    { 135, (byte)4, null, null, 6, 20, (byte)3 },
                    { 136, (byte)4, null, null, 6, 48, (byte)4 },
                    { 137, (byte)5, null, null, 6, 48, (byte)1 },
                    { 138, (byte)5, null, null, 6, 38, (byte)2 },
                    { 139, (byte)5, null, null, 6, 0, (byte)3 },
                    { 140, (byte)5, null, null, 6, 11, (byte)4 },
                    { 141, (byte)6, null, null, 6, 20, (byte)1 },
                    { 142, (byte)6, null, null, 6, 45, (byte)2 },
                    { 143, (byte)6, null, null, 6, 30, (byte)3 },
                    { 144, (byte)6, null, null, 6, 44, (byte)4 },
                    { 145, (byte)1, null, null, 7, 40, (byte)1 },
                    { 146, (byte)1, null, null, 7, 10, (byte)2 },
                    { 147, (byte)1, null, null, 7, 3, (byte)3 },
                    { 148, (byte)1, null, null, 7, 3, (byte)4 },
                    { 149, (byte)2, null, null, 7, 36, (byte)1 },
                    { 150, (byte)2, null, null, 7, 43, (byte)2 },
                    { 151, (byte)2, null, null, 7, 17, (byte)3 },
                    { 152, (byte)2, null, null, 7, 5, (byte)4 },
                    { 153, (byte)3, null, null, 7, 23, (byte)1 },
                    { 154, (byte)3, null, null, 7, 27, (byte)2 },
                    { 155, (byte)3, null, null, 7, 12, (byte)3 },
                    { 156, (byte)3, null, null, 7, 2, (byte)4 },
                    { 157, (byte)4, null, null, 7, 13, (byte)1 },
                    { 158, (byte)4, null, null, 7, 16, (byte)2 },
                    { 159, (byte)4, null, null, 7, 0, (byte)3 },
                    { 160, (byte)4, null, null, 7, 33, (byte)4 },
                    { 161, (byte)5, null, null, 7, 14, (byte)1 },
                    { 162, (byte)5, null, null, 7, 26, (byte)2 },
                    { 163, (byte)5, null, null, 7, 3, (byte)3 },
                    { 164, (byte)5, null, null, 7, 26, (byte)4 },
                    { 165, (byte)6, null, null, 7, 36, (byte)1 },
                    { 166, (byte)6, null, null, 7, 26, (byte)2 },
                    { 167, (byte)6, null, null, 7, 32, (byte)3 },
                    { 168, (byte)6, null, null, 7, 37, (byte)4 },
                    { 169, (byte)1, null, null, 8, 22, (byte)1 },
                    { 170, (byte)1, null, null, 8, 44, (byte)2 },
                    { 171, (byte)1, null, null, 8, 9, (byte)3 },
                    { 172, (byte)1, null, null, 8, 49, (byte)4 },
                    { 173, (byte)2, null, null, 8, 44, (byte)1 },
                    { 174, (byte)2, null, null, 8, 15, (byte)2 },
                    { 175, (byte)2, null, null, 8, 29, (byte)3 },
                    { 176, (byte)2, null, null, 8, 42, (byte)4 },
                    { 177, (byte)3, null, null, 8, 2, (byte)1 },
                    { 178, (byte)3, null, null, 8, 42, (byte)2 },
                    { 179, (byte)3, null, null, 8, 1, (byte)3 },
                    { 180, (byte)3, null, null, 8, 17, (byte)4 },
                    { 181, (byte)4, null, null, 8, 2, (byte)1 },
                    { 182, (byte)4, null, null, 8, 2, (byte)2 },
                    { 183, (byte)4, null, null, 8, 31, (byte)3 },
                    { 184, (byte)4, null, null, 8, 42, (byte)4 },
                    { 185, (byte)5, null, null, 8, 19, (byte)1 },
                    { 186, (byte)5, null, null, 8, 4, (byte)2 },
                    { 187, (byte)5, null, null, 8, 12, (byte)3 },
                    { 188, (byte)5, null, null, 8, 14, (byte)4 },
                    { 189, (byte)6, null, null, 8, 44, (byte)1 },
                    { 190, (byte)6, null, null, 8, 25, (byte)2 },
                    { 191, (byte)6, null, null, 8, 30, (byte)3 },
                    { 192, (byte)6, null, null, 8, 1, (byte)4 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoFoto",
                columns: new[] { "Id", "ProdutoId", "ArquivoFoto", "Destaque" },
                values: new object[,]
                {
                    { 1, 1, "/images/produtos/1/1.jpg", true },
                    { 1, 2, "/images/produtos/2/1.jpg", true },
                    { 1, 3, "/images/produtos/3/1.jpg", true },
                    { 1, 4, "/images/produtos/4/1.jpg", true },
                    { 1, 5, "/images/produtos/5/1.jpg", true },
                    { 1, 6, "/images/produtos/6/1.jpg", true },
                    { 1, 7, "/images/produtos/7/1.jpg", true },
                    { 1, 8, "/images/produtos/8/1.jpg", true },
                    { 1, 9, "/images/produtos/9/1.jpg", true },
                    { 1, 10, "/images/produtos/10/1.jpg", true },
                    { 1, 11, "/images/produtos/11/1.jpg", true },
                    { 1, 12, "/images/produtos/12/1.jpg", true },
                    { 2, 5, "/images/produtos/5/2.jpg", true },
                    { 3, 5, "/images/produtos/5/3.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "ProdutoTag",
                columns: new[] { "ProdutoId", "TagId" },
                values: new object[,]
                {
                    { 1, (byte)1 },
                    { 2, (byte)3 },
                    { 3, (byte)4 },
                    { 4, (byte)2 },
                    { 5, (byte)5 },
                    { 6, (byte)3 },
                    { 7, (byte)4 },
                    { 8, (byte)5 },
                    { 9, (byte)1 },
                    { 10, (byte)5 },
                    { 11, (byte)3 },
                    { 12, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "2ff54731-834c-46c5-9e68-a6a0aae5e796", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/users/avatar.png", "José Antonio Gallo Junior" });

            migrationBuilder.InsertData(
                table: "ProdutoCategoria",
                columns: new[] { "CategoriaId", "ProdutoId" },
                values: new object[] { (byte)6, 9 });

            migrationBuilder.InsertData(
                table: "ProdutoCategoria",
                columns: new[] { "CategoriaId", "ProdutoId" },
                values: new object[] { (byte)5, 10 });

            migrationBuilder.InsertData(
                table: "ProdutoCategoria",
                columns: new[] { "CategoriaId", "ProdutoId" },
                values: new object[] { (byte)6, 12 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_UsuarioId",
                table: "Blog",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_ProdutoId",
                table: "Carrinho",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_ProdutoEstoqueId",
                table: "CarrinhoProduto",
                column: "ProdutoEstoqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaPaiId",
                table: "Categoria",
                column: "CategoriaPaiId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaDesejo_UsuarioId",
                table: "ListaDesejo",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoAvaliacao_UsuarioId",
                table: "ProdutoAvaliacao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_CategoriaId",
                table: "ProdutoCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_CorId",
                table: "ProdutoEstoque",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_ProdutoId",
                table: "ProdutoEstoque",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_TamanhoId",
                table: "ProdutoEstoque",
                column: "TamanhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFoto_ProdutoId",
                table: "ProdutoFoto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoTag_TagId",
                table: "ProdutoTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "CarrinhoProduto");

            migrationBuilder.DropTable(
                name: "ListaDesejo");

            migrationBuilder.DropTable(
                name: "ProdutoAvaliacao");

            migrationBuilder.DropTable(
                name: "ProdutoCategoria");

            migrationBuilder.DropTable(
                name: "ProdutoFoto");

            migrationBuilder.DropTable(
                name: "ProdutoTag");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "ProdutoEstoque");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Tamanho");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
