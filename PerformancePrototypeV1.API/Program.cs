using Microsoft.EntityFrameworkCore;
using PerformancePrototypeV1.API.DAL;
using PerformancePrototypeV1.API.DAL.Repositories;
using PerformancePrototypeV1.API.Service.Transaction;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");

builder.Services.AddDbContextPool<InformationDBContext>(options =>
    options.UseSqlServer(connectionString));

//"Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;"
//Server -- DEEPA/MSSQLSERVER01 user -- "DEEPA\\dnali"

builder.Services.AddControllers();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
