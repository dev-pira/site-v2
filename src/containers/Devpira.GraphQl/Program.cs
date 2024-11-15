using Devpira.Infrastructure.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddSqlServerDbContext<ApplicationContext>("database");
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();

app.UseHttpsRedirection();

app.Run();
