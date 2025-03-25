using flying.nomad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlite("Data Source= ../Registrar.sqlite", 
b => b.MigrationsAssembly("flying.nomad.Api")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
