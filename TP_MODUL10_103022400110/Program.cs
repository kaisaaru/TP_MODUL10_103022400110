var builder = WebApplication.CreateBuilder(args);

// WAJIB ADA
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger (WAJIB)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// WAJIB untuk controller
app.MapControllers();

app.Run();