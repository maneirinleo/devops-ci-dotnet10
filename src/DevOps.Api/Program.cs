using DevOps.Api.Services;
 
var builder = WebApplication.CreateBuilder(args);

// Registro no Injetor de Dependências (DI) como Singleton
builder.Services.AddSingleton<CalculadoraService>();

var app = builder.Build();

// Endpoint de verificação de saúde da API
app.MapGet("/", ()=>
{
    return Results.Ok(new
    {
        mensagem = "API da atrividade de Integração Contínua",
        status = "ok"
    });
});

// Endpoint funcional que utiliza o serviço
app.MapGet(
    "/api/calculadora/somar/{primeiroNumero:int}/{segundoNumero:int}",
    (int primeiroNumero, int segundoNumero, CalculadoraService calculadora) =>
    {
        var resultado = calculadora.Somar(primeiroNumero, segundoNumero);
        return Results.Ok(new
        {
            primeiroNumero,
            segundoNumero,
            resultado
        });
    }
);
app.Run();