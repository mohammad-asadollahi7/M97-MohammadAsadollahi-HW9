using Data;
using Services.Abstract;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<ProductData>();
builder.Services.Configure<RouteOptions>(opt =>
{
    opt.LowercaseUrls = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
