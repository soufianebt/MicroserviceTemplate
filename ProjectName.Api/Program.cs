using Microsoft.EntityFrameworkCore;
using ProjectName.Data;
using ProjectName.Model;
using RegisterModule;

var builder = WebApplication.CreateBuilder(args);

var appSettings = builder.Configuration.Get<AppSettings>();

builder.Services.AddSingleton(appSettings);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
builder.Services.AddOpenApi();
builder.Services.RegisterServices();
builder.Services.AddDbContext<ProjectNameContext>(options => options.UseSqlServer(appSettings.connectionStrings.ProjectNameDb));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
