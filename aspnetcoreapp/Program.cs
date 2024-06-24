var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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

app.MapGet("/showRequest", (HttpRequest r) =>
{
    return $"scheme:{r.Scheme} host:{r.Host} port:{r.Host.Port} path: {r.Path}";
});


app.Run();
