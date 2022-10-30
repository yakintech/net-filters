using NetActionFilters.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalSampleActionFilter>();
});


var app = builder.Build();
app.MapDefaultControllerRoute();


app.Run();

