var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/test", () => "��� ����");

app.MapGet("/param", async context =>
{
    await context.Response.WriteAsync("��� ������ ����������:"
          + context.Request.QueryString.ToString());
});

app.MapGet("/html", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<h1>������</h1> ���!"
          + context.Request.QueryString.ToString());
});

app.MapGet("/func", HomePage);


app.Run();

async Task HomePage(HttpContext context)
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("������ �� �������!");
}
