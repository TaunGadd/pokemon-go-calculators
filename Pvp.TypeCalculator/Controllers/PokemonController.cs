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
    public async Task<ActionResult> CreatePokemon(PokemonDTO dto)
    {
        await _pokemonService.CreatePokemon(dto);
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<PokemonDTO>> GetPokemon(int id)
    {
        return await _pokemonService.GetPokemon(id);
    }

    [HttpPut]
    public async Task<ActionResult> UpdatePokemon(PokemonDTO dto)
    {
        await _pokemonService.UpdatePokemon(dto);
        return Ok();
    }

    [HttpDelete]
    public async Task<ActionResult<PokemonDTO>> DeletePokemon(int id)
    {
        return await _pokemonService.DeletePokemon(id);
    }
}
