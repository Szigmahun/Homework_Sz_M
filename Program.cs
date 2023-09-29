using Homework_Sz_M.Abstractions.Services;
using Homework_Sz_M.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IDataService, DataService>(client =>
{
    client.BaseAddress = new Uri("https://services.odata.org/V4/Northwind/Northwind.svc/");
});

builder.Services.AddCors(options => options.AddDefaultPolicy(
        configurePolicy => configurePolicy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin()
             ));


builder.Services.AddScoped<IDataService, DataService>();

var app = builder.Build();
app.UseCors();

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
