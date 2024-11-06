using Pvp.TypeCalculator.Moves;

namespace Pvp.TypeCalculator.Domain
{
    public interface IMovesRepo
    {
        public List<Move> GetAllMoves();
        public Move GetMove(string moveName);
    }
}
