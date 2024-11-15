using Microsoft.AspNetCore.Mvc;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Services;

namespace Pvp.TypeCalculator.Controllers;

public class MoveController : Controller
{
    private readonly IMoveService _moveService;

    public MoveController(IMoveService moveService)
    {
        _moveService = moveService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateMove(MoveDTO dto)
    {
        await _moveService.CreateMove(dto);
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<MoveDTO>> GetMove(int id)
    {
        return await _moveService.GetMove(id);
    }

    [HttpPatch]
    public async Task<ActionResult> UpdateMove(MoveDTO dto)
    {
        await _moveService.UpdateMove(dto);
        return Ok();
    }

    [HttpDelete]
    public async Task<ActionResult<MoveDTO>> DeleteMove(int id)
    {
        return await _moveService.DeleteMove(id);
    }
}
