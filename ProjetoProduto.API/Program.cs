using Microsoft.EntityFrameworkCore;
using ProjetoProduto.Application.Services;
using ProjetoProduto.Domain.Interfaces;
using ProjetoProduto.Infrastructure.Data;
using ProjetoProduto.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProdutosConnection")));

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoServices>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.MapGet("/", () => "Bem-vindo a API de contatos.\n /swagger para testar os endpoints.")
.WithName("Home")
.WithOpenApi();

app.Run();
