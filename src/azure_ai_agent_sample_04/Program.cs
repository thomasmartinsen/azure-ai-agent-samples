using Agents;
using Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.AddDefaults();
builder.Services.AddSingleton<IAgentHandler, AgentHandler>();
builder.Services.AddSingleton<IAgentService, AgentService>();
var app = builder.Build();
app.Start();

IAgentService agentService = app.Services.GetRequiredService<IAgentService>();
await agentService.RunAsync();
