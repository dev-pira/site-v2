using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var databaseServer = builder.AddSqlServer("DatabaseServer");
var database = databaseServer.AddDatabase("DevPira");

builder.AddProject<Devpira_WebApi>("webapi")
    .WithReference(database);

builder.Build().Run();
