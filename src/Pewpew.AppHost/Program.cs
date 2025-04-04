var builder = DistributedApplication.CreateBuilder(args);

builder.AddNpmApp("frontend", "../frontend", "dev")
       .WithHttpEndpoint(env: "PORT");

builder.Build().Run();
