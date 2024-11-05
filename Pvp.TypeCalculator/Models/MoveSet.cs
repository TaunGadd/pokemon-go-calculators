namespace Pvp.TypeCalculator.Models
{
    public class MoveSet
    {
        public Move FastMove { get; }
        public Move ChargeMove1 { get; }
        public Move ChargeMove2 { get; }

        public MoveSet(Move fm, Move cm1, Move cm2)
        {
            FastMove = fm;
            ChargeMove1 = cm1;
            ChargeMove2 = cm2;
        }
    }
}