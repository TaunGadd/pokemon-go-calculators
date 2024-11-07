using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Enums;
using Pvp.TypeCalculator.Models;
using Pvp.TypeCalculator.Moves;

namespace Pvp.TypeCalculator.Test;

[TestClass]
public class Battles
{
    IMoveRepository movesRepo;

    private Pokemon Bulbasaur;
    private Pokemon Diglett;

    [TestInitialize]
    public void Setup()
    {
        movesRepo = new FakeMoveRepository();

        CreatePokemon();
    }

    [TestMethod]
    public void BulbasaurVsDiglett()
    {
        // ACT
        var rating = Bulbasaur.Attack(Diglett);

        // Assert
        Assert.IsTrue(rating == 1);
    }

    [TestMethod]
    public void DiglettVsBulbasaur()
    {
        // ACT
        var rating = Diglett.Attack(Bulbasaur);

        // Assert
        Assert.IsTrue(rating == -1);
    }

    private void CreatePokemon()
    {
        var bulbasaur = new PokemonDTO
        {
            Name = "Bulbasaur",
            Type1 = PokemonType.Grass,
            Type2 = PokemonType.Poison,
            FastMove = MoveConstants.FastMoves._vineWhip,
            ChargeMove = MoveConstants.ChargeMoves._tackle
        };

        var diglett = new PokemonDTO
        {
            Name = "Diglett",
            Type1 = PokemonType.Ground,
            FastMove = MoveConstants.FastMoves._sandAttack,
            ChargeMove = MoveConstants.ChargeMoves._astonish
        };

        Bulbasaur = PokemonCreator(bulbasaur);
        Diglett = PokemonCreator(diglett);
    }

    private Pokemon PokemonCreator(PokemonDTO pokemon)
    {
        var moves = new MoveSet(
            movesRepo.GetMove(pokemon.FastMove),
            movesRepo.GetMove(pokemon.ChargeMove));

        return new Pokemon(pokemon.Name, moves, pokemon.Type1, pokemon.Type2 ?? pokemon.Type1);
    }
}