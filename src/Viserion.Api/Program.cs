using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Viserion.Application;
using Viserion.Domain;
using Viserion.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddDbContext<ViserionDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));
builder.Services.AddAutoMapper(x => { x.AddMaps(typeof(ProductDto).Assembly); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapDefaultControllerRoute();

app.Run();