using Microsoft.EntityFrameworkCore;
using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public class PokemonRepository : IPokemonRepository
{
    private readonly PGContext _dbContext;

    public PokemonRepository(PGContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreatePokemon(PokemonDTO dto)
    {
        await _dbContext.Pokemon.AddAsync(dto);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<PokemonDTO> DeletePokemon(int id)
    {
        var dto = await _dbContext.Pokemon.FindAsync(id);
        _dbContext.Pokemon.Remove(dto);
        await _dbContext.SaveChangesAsync();

        return dto;
    }

    public async Task<PokemonDTO> GetPokemon(int id)
    {
        return await _dbContext.Pokemon.FindAsync(id);
    }

    public async Task<List<PokemonDTO>> GetPokemon(List<int> ids)
    {
        return await _dbContext.Pokemon.Where(x => ids.Contains(x.Id)).ToListAsync();
    }

    public async Task UpdatePokemon(PokemonDTO dto)
    {
        var entity = await _dbContext.Pokemon.FindAsync(dto.Id);
        entity = dto;
        await _dbContext.SaveChangesAsync();
    }
}
