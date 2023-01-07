using File_Transfer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages()
    .Services.AddServerSideBlazor()
    .Services.AddSingleton<FileTransfareService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/Error");
app.UseStaticFiles().UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
