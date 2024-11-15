using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.ExceptionHandling;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Services;

public class MoveService : IMoveService
{
    private readonly IMoveRepository _moveRepository;

    public MoveService(IMoveRepository moveRepository)
    {
        _moveRepository = moveRepository;
    }

    public async Task CreateMove(MoveDTO move)
    {
        Guard.Against.NullValue(move, nameof(move));
        await _moveRepository.CreateMove(move);
    }

    public async Task<MoveDTO> DeleteMove(int id)
    {
        Guard.Against.NegativeOrZeroValue(id, nameof(id));
        return await _moveRepository.DeleteMove(id);
    }

    public async Task<MoveDTO> GetMove(int id)
    {
        Guard.Against.NegativeOrZeroValue(id, nameof(id));
        return await _moveRepository.GetMove(id);
    }

    public async Task UpdateMove(MoveDTO move)
    {
        Guard.Against.NullValue(move, nameof(move));
        await _moveRepository.UpdateMove(move);
    }
}
