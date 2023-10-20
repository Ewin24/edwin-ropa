using System.Reflection;
using AspNetCoreRateLimit;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// builder.Services.ConfigureRatelimiting();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
// builder.Services.configureCors();
// builder.Services.AddAplicationService();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RopaContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// app.UseCors("CorsPolicy");
// app.UseHttpsRedirection();
// app.UseIpRateLimiting();
app.UseAuthorization();
app.MapControllers();

app.Run();

// dotnet ef migrations add InitialCreate --project ./Infraestructura/ --startup-project ./API/ --output-dir ./Data/Migrations  // migracion Base de datos 
// dotnet ef database update --project ./Infraestructura/ --startup-project ./API/ // Actualizar Base de datos 
// dotnet run  --project API/ //Comando Para correr el proyecto
// dotnet tool install --global dotnet-ef