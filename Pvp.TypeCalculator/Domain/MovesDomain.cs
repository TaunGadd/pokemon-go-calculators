using Pvp.TypeCalculator.Moves;
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
                new Move(MoveConstants.FastMoves._vineWhip, PokemonType.Grass, MoveType.FastAttack),
                new Move(MoveConstants.FastMoves._sandAttack, PokemonType.Ground, MoveType.FastAttack),
                new Move(MoveConstants.ChargeMoves._tackle, PokemonType.Normal, MoveType.ChargeAttack),
                new Move(MoveConstants.ChargeMoves._acidSpray, PokemonType.Poison, MoveType.ChargeAttack),
                new Move(MoveConstants.ChargeMoves._astonish, PokemonType.Ghost, MoveType.ChargeAttack),
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
