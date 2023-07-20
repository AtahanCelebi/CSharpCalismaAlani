using Microsoft.EntityFrameworkCore;
using UserEfCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("UserListingDbConnectionString");
Console.WriteLine(connectionString);
builder.Services.AddDbContext<PhoneListingDbContext>(options => {
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 5, 15)));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

