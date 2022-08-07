// 1. Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
// importamos la carpeta DataAccess para tener acceso al context
using universityApiBackend.DataAcces;

/* El builder nos sirve para construir las configuraciones que va a utilizar nuestra app */
var builder = WebApplication.CreateBuilder(args);

// 2. Connection with SQL Server Express
const string CONNECTION_NAME = "UniversityDB";
// En appsettings.json tenemos una Connection String llamada UniversityDB
var connectionString = builder.Configuration.GetConnectionString(CONNECTION_NAME);

// 3. Add Context
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Si estamos en desarrollo
if (app.Environment.IsDevelopment())
{   // utilizamos Swagger para documentar la app
    app.UseSwagger();
    app.UseSwaggerUI();
}

// usa redireccion https
app.UseHttpsRedirection();

// usa autorización
app.UseAuthorization();

// Busca los controladores que tengamos asignados a cada ruta
app.MapControllers();

// Ejecuta la app
app.Run();

