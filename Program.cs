using ConnectHubAPI.Data;
using ConnectHubAPI.Repository;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var conexao = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conexao));

var host = builder.Configuration["DBHOST"] ?? "pc-joaovnr2-ae5b.d.aivencloud.com";
var port = builder.Configuration["DBPORT"] ?? "11577";
var password = builder.Configuration["DBPASSWORD"] ?? "AVNS_w9xL1rUgUMPCW6pG-aa";
var user = builder.Configuration["DBUSER"] ?? "avnadmin";

string conexao = $"server={host};userid={user};pwd={password};port={port}; database=defaultdb";

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(conexao, ServerVersion.AutoDetect(conexao)));

builder.Services.AddScoped<IRespostasParaoRepository, RespostasParaoRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

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
