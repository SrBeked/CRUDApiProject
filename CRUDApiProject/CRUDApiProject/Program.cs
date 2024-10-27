using Microsoft.EntityFrameworkCore;
using CRUDApiProject.Domain;
using CRUDApiProject.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio de DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("ProductDb"));

// Agregar servicios de controladores
builder.Services.AddControllers();

// Agregar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el middleware
app.UseHttpsRedirection();

// Activar Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
    c.RoutePrefix = string.Empty; // Hacer que Swagger UI esté en la raíz
});

app.UseAuthorization();
app.MapControllers();

app.Run();
