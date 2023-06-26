using OnBreakWeb.Interfaces;
using OnBreakWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<ITipoEmpresaService, TipoEmpresaService>();
builder.Services.AddScoped<IActividadEmpresaService, ActividadEmpresaService>();
builder.Services.AddScoped<IContratoService, ContratoService>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Cliente/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cliente}/{action=Lista}");

app.Run();
