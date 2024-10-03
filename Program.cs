using ManagerLabs.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionDb = builder.Configuration.GetConnectionString("MysqlConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(connectionDb, ServerVersion.AutoDetect(connectionDb)));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
