using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Services;

public interface IPokemonService
{
    Task CreatePokemon(PokemonDTO pokemon);
    Task<PokemonDTO> GetPokemon(int id);
    Task UpdatePokemon(PokemonDTO pokemon);
    Task<PokemonDTO> DeletePokemon(int id);
}