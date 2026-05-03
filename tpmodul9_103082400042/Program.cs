var builder = WebApplication.CreateBuilder(args);

// 1. Tambahkan servis Controller dan Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Baris ini wajib ada!

var app = builder.Build();

// 2. Aktifkan Middleware Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Ini yang bikin halaman /swagger muncul
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();