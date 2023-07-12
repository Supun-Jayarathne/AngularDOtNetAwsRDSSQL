using dgtestback.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var builder_aws = new SqlConnectionStringBuilder(builder.Configuration.GetConnectionString("DefaultConnection"));
//builder_aws.UserID = "admin";//Cnfiguration["DbUser"];
//builder_aws.Password = "AwsDesign123";//Configuration["DbPassword"];

builder.Services.AddDbContext<DGDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), builder =>
{
    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
