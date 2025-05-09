using BrewUpApiTemplate.Modules;
using BrewUpApiTemplate.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<SayHelloValidator>();

// Register Modules
builder.RegisterModules();

var app = builder.Build();

app.ConfigureModules();

await app.RunAsync();