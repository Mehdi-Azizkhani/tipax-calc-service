using Api.Configurations;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


Configurations.ConfigureServices(builder.Services);

var app = builder.Build();

Configurations.ConfigureApp(app);

app.Run();
