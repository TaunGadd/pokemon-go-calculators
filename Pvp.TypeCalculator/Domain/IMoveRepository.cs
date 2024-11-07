using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public interface IMoveRepository
{
    // CRUD
    Task CreateMove(MoveDTO dto);
    Task<MoveDTO> GetMove(int id);
    Task UpdateMove(MoveDTO dto);
    Task<MoveDTO> DeleteMove(int id);

    // Additional
    Task<MoveDTO> GetMove(string moveName);
    Task<List<MoveDTO>> GetAllMoves();
}
