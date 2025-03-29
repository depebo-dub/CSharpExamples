using System.Globalization;
using Microsoft.EntityFrameworkCore;
using WebApiExample.Db;
using WebApiExample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITaskExampleService, TaskExampleService>();
builder.Services.AddScoped<IOopExampleService, OopExampleService>();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

/*
try 
{
    logger.LogInformation("Пытаюсь подключиться к БД...");
    
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    
    // Явно открываем соединение с таймаутом
    await dbContext.Database.OpenConnectionAsync();
    logger.LogInformation("✅ Подключение к БД успешно установлено");
    
    // Дополнительная проверка - выполняем простой запрос
    var result = await dbContext.Database.ExecuteSqlRawAsync("SELECT 1");
    logger.LogInformation($"Тестовый запрос выполнен. Результат: {result}");
}
catch (Exception ex)
{
    logger.LogError(ex, "❌ Ошибка подключения к БД");
    // Здесь можно добавить дополнительные действия
}
*///Проверка коннекта к БД

// Настраиваем Swagger для разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection(); //Перенаправляет HTTP запросы на HTTPS
app.MapControllers();

// Здесь будем добавлять наши эндпоинты

app.Run();