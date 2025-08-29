Console.Clear();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//Funcionalidades
//Requisições
// - Endereço
// - Método HTTP
app.MapGet("/", () => "Estou com sonoooooooooo");

app.MapGet("/funcnionalidade", () => "Segundo sono");

app.MapPost("/funcnionalidade", () => "Terceiro sono");

app.Run();
