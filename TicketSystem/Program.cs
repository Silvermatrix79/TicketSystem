using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


//TODO: pathes not correct. must be changed for use
builder.Services.AddHttpClient("ProductApiController", c => c.BaseAddress = new Uri("https://localhost:7126/api/"));
builder.Services.AddHttpClient("AuthApiController", c => c.BaseAddress = new Uri("https://localhost:7239/api/Auth/"));



var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
