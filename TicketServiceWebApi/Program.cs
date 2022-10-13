using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TicketServiceWebApi.Data;
using TicketServiceWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TicketSystemDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.IgnoreNullValues = true;
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


builder.Services.AddScoped<IDepartmentService, DepartmentService>();


var app = builder.Build();

//Register Syncfusion license 
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHJqVVhkX1pFdkBAXXxLflF0VWdTflZ6dldWESFaRnZdQF1qS3lTd0ZlXXtZd3Jd;Mgo+DSMBMAY9C3t2VVhiQlFaclxJXGNWfFNpR2NbfU50flROal5TVAciSV9jS3xTf0dkWX5ddnBRTmBfWQ==;Mgo+DSMBPh8sVXJ0S0R+XE9AdVRDXXxLfkx0RWFbb1p6dV1MYl5BNQtUQF1hS35adEJjWHxYdHBdRGZU;NzIzNzY5QDMyMzAyZTMyMmUzMFI4WnhpcElCcFZZSjROQnhUZFhPVWhvQ3ltSU1RcmlPYnNBb0pIY3ErUW89");

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
