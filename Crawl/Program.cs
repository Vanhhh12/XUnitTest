using Crawl.Data;
using Crawl.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddCors(
    options => options.AddDefaultPolicy(
        policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
    )
);

builder.Services.AddScoped<ICrwalDataRepositories, CrawlDataRepositories>();

builder.Services.AddDbContext<AddressContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Addresss"));
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
