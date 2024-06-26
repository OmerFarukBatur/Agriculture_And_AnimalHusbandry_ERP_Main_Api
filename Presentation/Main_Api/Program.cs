﻿using Application;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Cors politikasýna ait ayarlarýn yapýlmasý
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5173", "https://localhost:5173").AllowCredentials();
}));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); // Cors politikasýna ait middleware

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
