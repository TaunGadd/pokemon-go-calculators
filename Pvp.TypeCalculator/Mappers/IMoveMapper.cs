using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Mappers;

public interface IMoveMapper
{
    MoveDTO Map(Move move);
    Move Map(MoveDTO dto);
}