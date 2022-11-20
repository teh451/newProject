using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRepositoryClaim, RepositoryClaim>();
builder.Services.AddScoped<IRepositoryPermission, RepositoryPermission>();
builder.Services.AddScoped<IRepositoryRole, RepositoryRole>();
builder.Services.AddSingleton<IContex, MockContext>();

builder.Services.AddAutoMapper(typeof(Mapping)); // לא עובד לי הפונקציה AddAutoMapper??

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
