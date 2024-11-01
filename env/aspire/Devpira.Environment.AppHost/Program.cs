using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Devpira_WebApi>("webapi");

builder.Build().Run();
