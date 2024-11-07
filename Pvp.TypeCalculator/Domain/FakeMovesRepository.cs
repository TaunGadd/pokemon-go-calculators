using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Moves;
using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.Domain;

public class FakeMovesRepository : IMovesRepository
{
    public Task CreateMove(MoveDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<MoveDTO> DeleteMove(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MoveDTO> GetMove(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMove(MoveDTO dto)
    {
        throw new NotImplementedException();
    }

    public async Task<List<MoveDTO>> GetAllMoves()
    {
        return await Task.FromResult(
            new List<MoveDTO>
            {
                new(MoveConstants.FastMoves._vineWhip, PokemonType.Grass, MoveType.FastAttack),
                new(MoveConstants.FastMoves._sandAttack, PokemonType.Ground, MoveType.FastAttack),
                new(MoveConstants.ChargeMoves._tackle, PokemonType.Normal, MoveType.ChargeAttack),
                new(MoveConstants.ChargeMoves._acidSpray, PokemonType.Poison, MoveType.ChargeAttack),
                new(MoveConstants.ChargeMoves._astonish, PokemonType.Ghost, MoveType.ChargeAttack),
            });
    }

    public async Task<MoveDTO> GetMove(string moveName)
    {
        var allMoves = await GetAllMoves();
        return allMoves.Find(x => x.Name == moveName);
    }
}
