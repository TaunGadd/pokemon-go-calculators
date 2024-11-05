using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.Models;

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
                movesRepo.GetMove(MoveConstants._tackle),
                movesRepo.GetMove(MoveConstants._vineWhip),
                movesRepo.GetMove(MoveConstants._acidSpray)
            );
        }
    }
}