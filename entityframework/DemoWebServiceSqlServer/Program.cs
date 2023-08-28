using Microsoft.EntityFrameworkCore;
using DemoWebServiceSqlServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// configurando o acesso ao bd sqlServer:
builder.Services.AddDbContext<TarefaContext>(opcoes => {
    opcoes.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); //pega do appsettings.json
    opcoes.EnableSensitiveDataLogging().LogTo(Console.WriteLine); //só em amb dev!
});
//registrar obj:
builder.Services.AddScoped<ITarefasRepository,TarefasRepositoryDB>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();