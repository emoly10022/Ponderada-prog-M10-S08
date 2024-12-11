using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting(); 

app.UseHttpMetrics();
app.MapMetrics(); 

app.Run();