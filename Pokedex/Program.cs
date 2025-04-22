using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PokedexContext>(options =>
options.UseSqlite("Data Source=pokedex.db"));
var app = builder.Build();


// Lista de pokémons fictícios para simulação
var pokemons = new List<Pokemon>
{
    new Pokemon { ID = 1, Nome = "Bulbasaur", Tipo = "Grama/Veneno"},
    new Pokemon { ID = 2, Nome = "Ivysaur", Tipo = "Grama/Veneno"},
    new Pokemon { ID = 3, Nome = "Venusaur", Tipo = "Grama/Veneno"},
    new Pokemon { ID = 4, Nome = "Chamander", Tipo = "Fogo"},
    new Pokemon { ID = 5, Nome = "Charmeleon", Tipo = "Fogo"},
    new Pokemon { ID = 6, Nome = "Charizard", Tipo = "Fogo/Voador"},
    new Pokemon { ID = 7, Nome = "Squirtle", Tipo = "Agua"},
    new Pokemon { ID = 8, Nome = "Wartotle", Tipo = "Agua"},
    new Pokemon { ID = 9, Nome = "Blastoise", Tipo = "Agua"}
};

// Endpoint para listar todos os pokémons
app.MapGet ("/pokemons", () =>
{
return Results.Ok(pokemons);

});

app.MapGet("/pokemons/{id}", ( int id) =>

{
var pokemon = pokemons.FirstOrDefault(p => p.ID == id);
return pokemon is not null ? Results.Ok(pokemon) : Results.NotFound();
});



//Iniciar
app.Run();