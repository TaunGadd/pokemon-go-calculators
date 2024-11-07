using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public interface IPokemonRepository
{
    // CRUD
    Task CreatePokemon(PokemonDTO dto);
    Task<PokemonDTO> GetPokemon(int id);
    Task UpdatePokemon(PokemonDTO dto);
    Task<PokemonDTO> DeletePokemon(int id);

    // Additonal
    Task<List<PokemonDTO>> GetPokemon(List<int> ids);
}