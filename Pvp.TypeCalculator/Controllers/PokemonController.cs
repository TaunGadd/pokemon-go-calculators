using Microsoft.AspNetCore.Mvc;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Services;

namespace Pvp.TypeCalculator.Controllers;

public class PokemonController : Controller
{
    private readonly IPokemonService _pokemonService;

    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }

    [HttpPost]
    public async Task CreatePokemon(PokemonDTO dto)
    {
        await _pokemonService.CreatePokemon(dto);
    }

    [HttpGet]
    public async Task<PokemonDTO> GetPokemon(int id)
    {
        return await _pokemonService.GetPokemon(id);
    }

    [HttpPut]
    public async Task UpdatePokemon(PokemonDTO dto)
    {
        await _pokemonService.UpdatePokemon(dto);
    }

    [HttpDelete]
    public async Task<PokemonDTO> DeletePokemon(int id)
    {
        return await _pokemonService.DeletePokemon(id);
    }
}
