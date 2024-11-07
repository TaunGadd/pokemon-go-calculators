using Microsoft.AspNetCore.Mvc;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Services;

namespace Pvp.TypeCalculator.Controllers;

public class PokemonController : Controller
{
    IPokemonService _pokemonService;

    public PokemonController(PokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    [HttpPost]
    public async void CreatePokemon(PokemonDTO pokemon)
    {
        await _pokemonService.CreatePokemon(pokemon);
    }

    [HttpGet]
    public async Task<PokemonDTO> GetPokemon(int id)
    {
        return await _pokemonService.GetPokemon(id);
    }

    [HttpPut]
    public async Task UpdatePokemon(PokemonDTO pokemon)
    {
        await _pokemonService.UpdatePokemon(pokemon);
    }

    [HttpDelete]
    public async Task<PokemonDTO> DeletePokemon(int id)
    {
        return await _pokemonService.DeletePokemon(id);
    }
}
