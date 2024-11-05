using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Domain
{
    //TODO Move to DB
    public class MovesDomain : IMovesRepo
    {
        public List<Move> GetAllMoves()
        {
            return new List<Move>
            {
                new Move(MoveConstants._tackle, PokemonType.Normal),
                new Move(MoveConstants._vineWhip, PokemonType.Grass),
                new Move(MoveConstants._acidSpray, PokemonType.Poison),
            };
        }
    }
}
