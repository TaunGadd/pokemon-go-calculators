using Pvp.TypeCalculator.Calculator;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Enums;

namespace Pvp.TypeCalculator.Models;

public class Pokemon
{
    public readonly IPokemonTypeInteraction _typeInteraction;

    public Pokemon(IPokemonTypeInteraction typeInteraction)
    {
        _typeInteraction = typeInteraction;
    }

    public Pokemon()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public PokemonType Type1 { get; set; }
    public PokemonType Type2 { get; set; }
    public MoveSet MoveSet { get; set; }
    public bool IsDualType => Type1 != Type2;

    public async Task<BattleResultDTO> Attack(Pokemon target)
    {
        return new BattleResultDTO
        {
            Rating = await _typeInteraction.InitiateAttack(this, target)
        };
    }
}
