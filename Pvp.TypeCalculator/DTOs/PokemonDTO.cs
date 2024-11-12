using Pvp.TypeCalculator.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pvp.TypeCalculator.DTOs;

public class PokemonDTO
{
    [Key]
    public int Id;
    public required string Name;
    public required PokemonType Type1;
    public PokemonType? Type2;
    public required string FastMove;
    public required string ChargeMove1;
    public required string ChargeMove2;
}