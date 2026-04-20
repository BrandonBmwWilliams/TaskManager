using Microsoft.EntityFrameworkCore;
using TaskManager.Server.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=helpdesk.db"));

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();