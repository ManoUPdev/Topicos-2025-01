var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Lista de pokemons inciais pelo menos uma demonstração
var pokemons = new List<Pokemon>
{
    
    new Pokemon { Numero = 1, Nome = "Bulbasaur", Tipo = "Grama" },
    new Pokemon { Numero = 2, Nome = "Ivysaur", Tipo = "Grama/Venenoso" },
    new Pokemon { Numero = 3, Nome = "Venusaur", Tipo = "Grama/Venenoso" },
    new Pokemon { Numero = 4, Nome = "Charmander", Tipo = "Fogo" },
    new Pokemon { Numero = 5, Nome = "Charmeleon", Tipo = "Fogo" },
    new Pokemon { Numero = 6, Nome = "Charizard", Tipo = "Fogo/Voador" }
}

//Endpoint para listar todos os pokemons disponiveis
app.MapGet("/pokemons", () =>
{
    return Results.Ok(pokemons)
}

//Endpoint para pegar um pokemon
app.Map("/pokemons/{numero}"), (int numero) =>
{
    var pokemon
    return pokemon is not null ? Results.Ok(pokemon) : Results.NotFound();  
});

app.Run();