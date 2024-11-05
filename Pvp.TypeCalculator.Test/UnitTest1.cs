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
            var allMoves = movesRepo.GetAllMoves();

            MoveSet bulbasaurMoves = new MoveSet(
                allMoves.Find(x => x.Name == MoveConstants._tackle),
                allMoves.Find(x => x.Name == MoveConstants._vineWhip),
                allMoves.Find(x => x.Name == MoveConstants._acidSpray)
            );
        }
    }
}