using Pvp.TypeCalculator.Moves;
using Pvp.TypeCalculator.PokemonTypes;
using System.ComponentModel.DataAnnotations;

namespace Pvp.TypeCalculator.DTOs;

public class MoveDTO
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public PokemonType Type { get; set; }
    public MoveType MoveType { get; set; }

    public MoveDTO(string name, PokemonType type, MoveType moveType)
    {
        Name = name;
        Type = type;
        MoveType = moveType;
    }
}
