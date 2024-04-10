using Microsoft.EntityFrameworkCore;
using ServerApi.Models;
using ServerApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "MyAllowOrigins", policy =>
	{
		//Thay bằng địa chỉ localhost khi khởi chạy bên frontend (VSCode)
		policy.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500")
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//Đặt trên UseAuthorization
app.UseCors("MyAllowOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
