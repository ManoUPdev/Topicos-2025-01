using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PokedexContext>(options =>
options.UseSqlite("Data Source=pokedex.db"));
var app = builder.Build();


// Lista de pokémons fictícios para simulação
var pokemons = new List<Pokemon>
{
    new Pokemon { Id = 1, Nome = "Bulbasaur", Tipo = "Grama/Veneno"},
    new Pokemon { Id = 2, Nome = "Ivysaur", Tipo = "Grama/Veneno"},
    new Pokemon { Id = 3, Nome = "Venusaur", Tipo = "Grama/Veneno"},
    new Pokemon { Id = 4, Nome = "Chamander", Tipo = "Fogo"},
    new Pokemon { Id = 5, Nome = "Charmeleon", Tipo = "Fogo"},
    new Pokemon { Id = 6, Nome = "Charizard", Tipo = "Fogo/Voador"},
    new Pokemon { Id = 7, Nome = "Squirtle", Tipo = "Agua"},
    new Pokemon { Id = 8, Nome = "Wartotle", Tipo = "Agua"},
    new Pokemon { Id = 9, Nome = "Blastoise", Tipo = "Agua"}
};

// Endpoint para listar todos os pokémons
app.MapGet ("/pokemons", () =>
{
return Results.Ok(pokemons);

});

app.MapGet("/pokemons/{id}", ( int id) =>

{
var pokemon = pokemons.FirstOrDefault(p => p.Id == id);
return pokemon is not null ? Results.Ok(pokemon) : Results.NotFound();
});



//Iniciar
app.Run();