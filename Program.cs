using Microsoft.EntityFrameworkCore;
using Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=productos.db"));

// Agregar controladores
builder.Services.AddControllers();

// Configurar CORS para permitir Vue
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVue", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Swagger/OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Crear la base de datos si no existe
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowVue");

app.MapControllers();

app.Run();
