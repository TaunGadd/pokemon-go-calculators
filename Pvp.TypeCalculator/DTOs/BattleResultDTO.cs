namespace Pvp.TypeCalculator.DTOs;

public class BattleResultDTO
{
    public double Rating { get; set; }
    public bool Victory => Rating > 0;
}