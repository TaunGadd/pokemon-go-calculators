using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.Moves;
using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        IMovesRepo movesRepo;

        public void Setup()
        {
            movesRepo = new MovesDomain();
        }

        [TestMethod]
        public void TestMethod1()
        {
            MoveSet bulbasaurMoves = new MoveSet(
                movesRepo.GetMove(MoveConstants.FastMoves._vineWhip),
                movesRepo.GetMove(MoveConstants.ChargeMoves._tackle)
            );

            var bulbasaur = new Pokemon("Bulbasaur", bulbasaurMoves, PokemonType.Grass, PokemonType.Poison);

            MoveSet diglettMoves = new MoveSet(
                movesRepo.GetMove(MoveConstants.FastMoves._sandAttack),
                movesRepo.GetMove(MoveConstants.ChargeMoves._astonish)
            );

            var diglett = new Pokemon("Diglett", diglettMoves, PokemonType.Ground);

            bulbasaur.Attack(diglett);
        }
    }
}