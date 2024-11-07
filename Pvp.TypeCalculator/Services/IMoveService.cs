using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Services;

public interface IMoveService
{
    Task CreateMove(MoveDTO move);
    Task<MoveDTO> GetMove(int id);
    Task UpdateMove(MoveDTO move);
    Task<MoveDTO> DeleteMove(int id);
}
