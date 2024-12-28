using CrudWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Agregamos servicios
//String de conexion
var connectionString = builder.Configuration.GetConnectionString("SQLServer");


// Add services to the container.
builder.Services.AddControllersWithViews();

//Agregamos el contexto de la base de datos
builder.Services.AddDbContext<PersonaDbContext>(options =>
{
    //Registrar tipoo de base de datos
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
