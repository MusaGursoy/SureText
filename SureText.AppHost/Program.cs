var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

// Add PostgreSQL container
var postgres = builder.AddPostgres("postgres")
    .AddDatabase("suretext-postgresdb");

var apiService = builder.AddProject<Projects.SureText_ApiService>("apiservice")
    .WithReference(postgres); // Connect the API service to PostgreSQL

builder.AddProject<Projects.SureText_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
