using Pvp.TypeCalculator.Pokemon;
using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.Domain
{
    //TODO Move to DB
    public class MovesDomain : IMovesRepo
    {
        public List<Move> GetAllMoves()
        {
            return new List<Move>
            {
                new Move(MoveConstants.FastMoves._vineWhip, PokemonType.Grass),
                new Move(MoveConstants.FastMoves._sandAttack, PokemonType.Ground),
                new Move(MoveConstants.ChargeMoves._tackle, PokemonType.Normal),
                new Move(MoveConstants.ChargeMoves._acidSpray, PokemonType.Poison),
                new Move(MoveConstants.ChargeMoves._astonish, PokemonType.Ghost),
            };
        }

        public Move GetMove(string moveName)
        {
            var move = GetAllMoves().Find(x => x.Name == moveName);

            if (move == null)
            {
                // Create MoveNotFoundException();
                throw new Exception();
            }

            return move;
        }
    }
}
