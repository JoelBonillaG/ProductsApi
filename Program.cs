using dotenv.net;
using Microsoft.EntityFrameworkCore;

using ProductsApi.Data;

var builder = WebApplication.CreateBuilder(args);

// load .env file variables into the environment variables
DotEnv.Load();

var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION"); // get the connection string from the environment variables

// Registrar DbContext para EF Core
builder.Services.AddDbContext<ProductsDbContext>(options =>
    options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


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
