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
    public async Task CreateMove(MoveDTO dto)
    {
        await _moveService.CreateMove(dto);
    }

    [HttpGet]
    public async Task<MoveDTO> GetMove(int id)
    {
        return await _moveService.GetMove(id);
    }

    [HttpPatch]
    public async Task UpdateMove(MoveDTO dto)
    {
        await _moveService.UpdateMove(dto);
    }

    [HttpDelete]
    public async Task<MoveDTO> DeleteMove(int id)
    {
        return await _moveService.DeleteMove(id);
    }
}
