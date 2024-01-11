global using FastEndpoints;
global using FluentValidation;

using FastEndpoints.Swagger;

var b = WebApplication.CreateBuilder();
b.Services.AddFastEndpoints();
b.Services.SwaggerDocument();

var app = b.Build();
app.UseFastEndpoints();
app.UseSwaggerGen();
app.Run();


