using Microsoft.EntityFrameworkCore;
using Superheroes001.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// add our service for DB
builder.Services.AddDbContext<DatabaseContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

//    var connectionString = builder.Configuration.GetConnectionString("AppDb");
//builder.Services.AddDbContext<EmployeeDbContext>(x => x.UseSqlServer(connectionString));
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
