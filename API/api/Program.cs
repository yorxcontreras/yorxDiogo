var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",()=>"hello man");

app.MapGet("/segundafuncionalidade",()=>"segundo hello man");

app.MapGet("/retornar",()=>
{
    dynamic endereco = new {
        rua = "parigo de sousa",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

//criar um funcionalidade 

app.Run();