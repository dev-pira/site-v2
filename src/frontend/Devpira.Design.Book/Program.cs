using BlazingStory.Components;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Devpira.Design.Book.Components.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceDefaults();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var serverUrl = builder.Configuration[WebHostDefaults.ServerUrlsKey]?.Split(';').FirstOrDefault() ?? "http://localhost:5002";
builder.Services.TryAddScoped(sp => new HttpClient { BaseAddress = new Uri(serverUrl) });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

app.MapRazorComponents<BlazingStoryServerComponent<IndexPage, IFramePage>>()
    .AddInteractiveServerRenderMode();

app.Run();
