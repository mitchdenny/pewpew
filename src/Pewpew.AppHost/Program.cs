var builder = DistributedApplication.CreateBuilder(args);

var backend = builder.AddProject<Projects.Pewpew_Backend>("backend");

builder.AddNpmApp("frontend", "../frontend", "dev")
        .WithHttpEndpoint(env: "PORT")
        .WithReference(backend)
        .PublishAsDockerFile();

builder.Build().Run();
