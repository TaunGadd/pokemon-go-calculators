namespace Pvp.TypeCalculator.Moves;

public class MoveSet
{
    public Move FastMove { get; }
    public Move ChargeMove { get; }

    public MoveSet(Move fm, Move cm)
    {
        FastMove = fm;
        ChargeMove = cm;
    }
}