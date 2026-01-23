var builder = WebApplication.CreateBuilder(args);

//EL CONSTRUCTOR INDICARA COMO GENERAR LA APP
//MEDIANTE METODOS LE INDICAMOS EL TIPADO DE APP
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
