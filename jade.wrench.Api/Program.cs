using jade.wrench.Data;
using Microsoft.EntityFrameworkCore;
using EventFlow.SQLite;
using Microsoft.EntityFrameworkCore.Sqlite;
 
var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
 
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<StoreContext>(options => options.useSqlite("Data Source= ../Registrar.sqlite",
b => b.MigrationsAssembly("jade.wrench.Api"))
);
builder.Services.AddEndpointsApiExplorer();
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
 
app.UseHttpsRedirection();
 
app.UseAuthorization();
 
app.MapControllers();
 
app.Run();