using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Mappers;

public interface IPokemonMapper
{
    PokemonDTO Map(Pokemon pokemon);
    Pokemon Map(PokemonDTO pokemon, MoveSet moveSet);
}