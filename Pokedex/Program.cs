using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PokedexContext>(options =>
   options.UseSqlite("Data Source=pokedex.db"));


var app = builder.Build();

// Funcoes da Pokedex

app.MapGet("/pokemons", async (PokedexContext db =>
await double.Pokemons.ToListAsync()));





app.Run();