using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Enums;

namespace Pvp.TypeCalculator.Domain;

// TODO
public class FakeMoveRepository : IMoveRepository
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
                new MoveDTO { Name = MoveConstants.FastMoves._vineWhip, Type = PokemonType.Grass, MoveType = MoveType.FastAttack},
                new MoveDTO { Name = MoveConstants.FastMoves._sandAttack, Type = PokemonType.Ground, MoveType = MoveType.FastAttack },
                new MoveDTO { Name = MoveConstants.ChargeMoves._tackle, Type = PokemonType.Normal, MoveType = MoveType.ChargeAttack },
                new MoveDTO { Name = MoveConstants.ChargeMoves._acidSpray, Type = PokemonType.Poison, MoveType = MoveType.ChargeAttack },
                new MoveDTO { Name = MoveConstants.ChargeMoves._astonish, Type = PokemonType.Ghost, MoveType = MoveType.ChargeAttack }
            });
    }

    public async Task<MoveDTO> GetMove(string moveName)
    {
        var allMoves = await GetAllMoves();
        return allMoves.Find(x => x.Name == moveName);
    }
}
