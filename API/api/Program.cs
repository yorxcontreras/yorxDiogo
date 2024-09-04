using api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",()=>" API de Produto");

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto()
{
    Nome = "Notebook",
    Preco = 2000,
    Quantidade = 54
});
produtos.Add(new Produto()
{
    Nome = "pc",
    Preco = 5000,
    Quantidade = 23
});produtos.Add(new Produto()
{
    Nome = "Grafic",
    Preco = 800,
    Quantidade = 78
});
produtos.Add(new Produto()
{
    Nome = "CPU",
    Preco = 1200,
    Quantidade = 75
});

app.MapGet("/produto/listar", (string nome) => 
{
    return Results.Ok (produtos);
});

//GET:/produto/cadastrar

app.MapGet("/produto/cadastrar/{nome}", (string nome) => 
{
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return Results.Ok(produtos);
});


//criar um funcionalidade 



app.Run();



// Produto produto = new Produto();
// produto.Preco = 5;
// produto.
// Console.WriteLine("Preco: " + produto.Preco);

// Produto produto = new Produto();
// produto.setPreco(5);
// Console.WriteLine("Preco: " + produto.getPreco());