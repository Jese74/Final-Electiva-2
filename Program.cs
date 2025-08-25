var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => " Hola Mundo. Como esta Familiaaaa .");

var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
app.Urls.Add($"http://*:{port}");

app.Run();  
