using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var database = builder
    .AddAzureSqlServer("databaseServer")
    .RunAsContainer()
    .AddDatabase("database");

var webapi = builder.AddProject<Devpira_WebApi>("webapi")
    .WithReference(database);
builder.AddProject<Devpira_Migrations>("migrations")
    .WithReference(database)
    .WaitFor(database);

builder.AddProject<Devpira_Web>("web")
    .WithReference(webapi);

builder.AddProject<Devpira_Design_Book>("design");

builder.Build().Run();
