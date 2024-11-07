using Microsoft.EntityFrameworkCore;
using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public class MovesRepository : IMovesRepository
{
    private PokemonGoContext _dbContext;

    public MovesRepository(PokemonGoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateMove(MoveDTO dto)
    {
        await _dbContext.Moves.AddAsync(dto);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<MoveDTO> DeleteMove(int id)
    {
        var dto = await _dbContext.Moves.FindAsync(id);
        _dbContext.Moves.Remove(dto);
        await _dbContext.SaveChangesAsync();

        return dto;
    }

    public async Task<List<MoveDTO>> GetAllMoves()
    {
        return await _dbContext.Moves.ToListAsync();
    }

    public async Task<MoveDTO> GetMove(int id)
    {
        return await _dbContext.Moves.FindAsync(id);
    }

    public async Task<MoveDTO> GetMove(string moveName)
    {
        return await _dbContext.Moves.FirstOrDefaultAsync(x => x.Name == moveName);
    }

    public async Task UpdateMove(MoveDTO dto)
    {
        var entity = await _dbContext.Moves.FindAsync(dto.Id);
        entity = dto;
        await _dbContext.SaveChangesAsync();
    }
}
