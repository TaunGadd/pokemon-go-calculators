using Microsoft.EntityFrameworkCore;
using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public class PGContext : DbContext
{
    public DbSet<PokemonDTO> Pokemon { get; set; }
    public DbSet<MoveDTO> Moves { get; set; }
}
