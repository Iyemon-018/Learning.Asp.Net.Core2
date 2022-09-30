using Learning.Asp.Net.Core2.Domain;
using Learning.Asp.Net.Core2.infrastructure.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// .NET6 ‚ÍˆÈ‰º‚Ì‚æ‚¤‚È•û–@‚Å DI ‚Å‚«‚éB
// cf. https://learn.microsoft.com/ja-jp/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0
builder.Services.AddSingleton<IUnitOfWork>(_ => Factories.UnitOfWork());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(configure =>
{
    configure.MapControllerRoute(name: "default"
          , pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();