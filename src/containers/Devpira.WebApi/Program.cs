using Devpira.Infrastructure.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceDefaults();
builder.AddSqlServerDbContext<ApplicationContext>("database");
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
app.UseSwaggerUI(o => o.SwaggerEndpoint("/openapi/v1.json", "v1"));

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello world!");

app.Run();
