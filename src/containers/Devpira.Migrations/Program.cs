using Devpira.Migrations;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.AddSqlServerDbContext<MigrationsContext>("database");

var host = builder.Build();

using var scope = host.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<MigrationsContext>();
context.Database.Migrate();

host.Start();