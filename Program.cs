using WebApp.Domain;
using WebApp.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ITemplateService, TemplateService>();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(b => b
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseHttpsRedirection();

app.MapGet("/name", (ITemplateService templateService, string name) 
    => templateService.RenderComponent("name", new KeyValuePair<string, string>("name", name)));

app.Run();