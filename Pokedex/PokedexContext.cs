using Microsoft.EntityFrameworkCore;


    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options) 
             : base(options) {}

        public DbSet<Pokemon> Pokemons { get; set; } = null!;
    }
