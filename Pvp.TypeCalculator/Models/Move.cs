using Pvp.TypeCalculator.Enums;

namespace Pvp.TypeCalculator.Models;

public class Move
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PokemonType Type { get; set; }
    public MoveType MoveType { get; set; }
}