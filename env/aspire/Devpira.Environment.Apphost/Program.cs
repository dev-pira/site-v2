using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var databaseServer = builder.AddSqlServer("databaseServer");
var database = databaseServer.AddDatabase("database");

var webapi = builder.AddProject<Devpira_WebApi>("webapi")
    .WithReference(database);
var graphql = builder.AddProject<Devpira_GraphQl>("graphql")
    .WithReference(database);
var migrations = builder.AddProject<Devpira_Migrations>("migrations")
    .WithReference(database);

var web = builder.AddProject<Devpira_Web>("web")
    .WithReference(graphql);
var admin = builder.AddProject<Devpira_Web_Admin>("admin")
    .WithReference(webapi);

builder.Build().Run();
