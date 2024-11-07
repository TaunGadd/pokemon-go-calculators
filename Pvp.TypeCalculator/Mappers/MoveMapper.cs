using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Mappers;

public class MoveMapper : IMoveMapper
{
    public MoveDTO Map(Move move)
    {
        return new MoveDTO
        {
            Id = move.Id,
            Name = move.Name,
            Type = move.Type,
            MoveType = move.MoveType
        };
    }

    public Move Map(MoveDTO dto)
    {
        return new Move
        {
            Id = dto.Id,
            Name = dto.Name,
            Type = dto.Type,
            MoveType = dto.MoveType
        };
    }
}
