var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapFallbackToFile("/{*path:nonfile}", "index.html");
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapFallbackToFile("/{*path:nonfile}", "index.html");
// });

app.Run();
