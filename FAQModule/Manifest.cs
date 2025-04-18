using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "FAQModule",
    Author = "The Orchard Core Team",
    Website = "https://orchardcore.net",
    Version = "0.0.1",
    Description = "FAQModule",
    Dependencies = new[] { "OrchardCore.Contents", "OrchardCore.ContentFields", "OrchardCore.Media" },
    Category = "Content Management"
)]
