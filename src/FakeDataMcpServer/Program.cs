using FakeDataMcpServer.Tools;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithTools<ProdutosFakeDataTool>()
    .WithTools<EmpresasFakeDataTool>()
    .WithTools<ContatosFakeDataTool>();

var app = builder.Build();

app.MapMcp();

app.Run();