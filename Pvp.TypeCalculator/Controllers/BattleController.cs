using Microsoft.AspNetCore.Mvc;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Services;

namespace Pvp.TypeCalculator.Controllers;

public class BattleController : Controller
{
    IBattleService _battleService;

    public BattleController(IBattleService battleService)
    {
        _battleService = battleService;
    }

    [HttpPost]
    public async Task<BattleResultDTO> Battle(int attackerId, int defenderId)
    {
        return await _battleService.Battle(attackerId, defenderId);
    }
}
