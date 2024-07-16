using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrchardSite.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContactFormContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContactFormContext") 
    ?? throw new InvalidOperationException("Connection string 'ContactFormContext' not found.")));

// Add services to the container.
builder.Services.AddOrchardCms();

var app = builder.Build();

app.UseStaticFiles();
app.UseOrchardCore();

app.Run();
