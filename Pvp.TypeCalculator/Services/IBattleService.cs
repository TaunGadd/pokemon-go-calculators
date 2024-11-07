using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Services;

public interface IBattleService
{
    Task<BattleResultDTO> Battle(int attackerId, int defenderId);
}
