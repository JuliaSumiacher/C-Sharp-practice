/*Crear un proyecto de API .Net 8, y crear las entidades "Colegio" , "Clase", "Profesor" y "Alumno".
Con Entity Framework Core, genera las migraciones y el esquema de la BBDD, para realizar el CRUD de cada entidad.
Se deja en el alumno, como relacionar las entidades entre si.Puedes usar LocalDB o SQL server de Azure, como prefieras.
*/

using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
    sqlOptions => sqlOptions.EnableRetryOnFailure()));


builder.Services.AddTransient<IAlumnoService, AlumnoService>();
builder.Services.AddTransient<IAlumnoRepositorio, AlumnoRepositorio>();

builder.Services.AddTransient<IProfesorService, ProfesorService>();
builder.Services.AddTransient<IProfesorRepositorio, ProfesorRepositorio>();

builder.Services.AddTransient<IColegioService, ColegioService>();
builder.Services.AddTransient<IColegioRepositorio, ColegioRepositorio>();

builder.Services.AddTransient<IClaseService, ClaseService>();
builder.Services.AddTransient<IClaseRepositorio, ClaseRepositorio>();

builder.Services.AddTransient<IReporteService, ReporteService>();
builder.Services.AddTransient<IReporteRepositorio, ReporteRepositorio>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
