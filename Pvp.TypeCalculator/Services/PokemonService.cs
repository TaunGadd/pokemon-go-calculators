using AsGuard.Api.Validator;
using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Services;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonService(IPokemonRepository pokemonRepository)
    {
        _pokemonRepository = pokemonRepository;
    }

    public async Task CreatePokemon(PokemonDTO pokemon)
    {
        Guard.Against.NullValue(pokemon, nameof(pokemon));
        await _pokemonRepository.CreatePokemon(pokemon);
    }

    public async Task<PokemonDTO> GetPokemon(int id)
    {
        Guard.Against.NegativeOrZeroValue(id, nameof(id));
        return await _pokemonRepository.GetPokemon(id);
    }

    public async Task UpdatePokemon(PokemonDTO pokemon)
    {
        Guard.Against.NullValue(pokemon, nameof(pokemon));
        await _pokemonRepository.UpdatePokemon(pokemon);
    }

    public async Task<PokemonDTO> DeletePokemon(int id)
    {
        Guard.Against.NegativeOrZeroValue(id, nameof(id));
        return await _pokemonRepository.DeletePokemon(id);
    }
}
