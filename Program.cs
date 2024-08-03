using File_Transfer;
using File_Transfer.Services;
 using Microsoft.AspNetCore.Components;
 using Microsoft.AspNetCore.Components.Web;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents().Services.AddSingleton<FileTransfareService>();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
  app.UseExceptionHandler("/Error").UseHsts();


app.UseHttpsRedirection().UseStaticFiles().UseAntiforgery().UseStatusCodePagesWithRedirects("/404");

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
