using dataservice.Services;
using dataservice.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add ApiKey security ...
var apiKeyProvider = ApiKeyProvider.Initialize("InventoryApi:ApiKey");
builder.Services.AddApiKeyAuthentication(apiKeyProvider);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseAuthorization();

app.MapControllers();

app.Run();
