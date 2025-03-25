using WebApiExample.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

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