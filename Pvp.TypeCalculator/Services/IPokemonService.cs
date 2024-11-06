using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Services
{
    public interface IPokemonService
    {
        Task CreatePokemon(PokemonDTO pokemon);
        Task<PokemonDTO> ReadPokemon(int id);
        Task<PokemonDTO> UpdatePokemon(PokemonDTO pokemon);
        Task<PokemonDTO> DeletePokemon(int id);
    }
}