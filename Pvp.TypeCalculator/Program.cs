
using AsGuard.Api.Validator.Middelware;
using Pvp.TypeCalculator.Calculator;
using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.Mappers;
using Pvp.TypeCalculator.Services;

var builder = WebApplication.CreateBuilder(args);

RegisterDependancyInjection(builder);

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

app.UseMiddleware<GuardMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void RegisterDependancyInjection(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<IPokemonTypeInteraction, BasicInteraction>();
    //builder.Services.AddScoped<IMoveRepository, MoveRepository>();
    builder.Services.AddScoped<IMoveRepository, FakeMoveRepository>();
    //builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
    builder.Services.AddScoped<IPokemonRepository, FakePokemonRepository>();
    builder.Services.AddScoped<IMoveMapper, MoveMapper>();
    builder.Services.AddScoped<IPokemonMapper, PokemonMapper>();
    builder.Services.AddScoped<IBattleService, BattleService>();
    builder.Services.AddScoped<IMoveService, MoveService>();
    builder.Services.AddScoped<IPokemonService, PokemonService>();
}
