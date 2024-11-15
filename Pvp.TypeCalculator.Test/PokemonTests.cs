using Pvp.TypeCalculator.Constants;
using Pvp.TypeCalculator.Enums;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Test;

[TestClass]
public class PokemonTests
{
    private Pokemon _bulbasaur;
    private Pokemon _diglett;

    [TestInitialize]
    public void Setup()
    {
        CreatePokemon();
    }

    [TestMethod]
    public async void BulbasaurVsDiglett()
    {
        // ACT
        var result = await _bulbasaur.Attack(_diglett);

        // Assert
        Assert.IsTrue(result.Rating == 1);
    }

    [TestMethod]
    public async void DiglettVsBulbasaur()
    {
        // ACT
        var result = await _diglett.Attack(_bulbasaur);

        // Assert
        Assert.IsTrue(result.Rating == -1);
    }

    private void CreatePokemon()
    {
        _bulbasaur = new Pokemon
        {
            Name = "Bulbasaur",
            Type1 = PokemonType.Grass,
            Type2 = PokemonType.Poison,
            MoveSet = new MoveSet{ 
                FastMove = new Move { Name = MoveConstants.FastMoves._vineWhip, MoveType = MoveType.FastAttack, Type = PokemonType.Grass },
                ChargeMove1 = new Move { Name = MoveConstants.ChargeMoves._tackle, MoveType = MoveType.ChargeAttack, Type = PokemonType.Normal},
                ChargeMove2 = new Move { Name = MoveConstants.ChargeMoves._solarBeam, MoveType = MoveType.ChargeAttack, Type = PokemonType.Grass},
            },
        };

        _diglett = new Pokemon
        {
            Name = "Diglett",
            Type1 = PokemonType.Ground,
            MoveSet = new MoveSet
            {
                FastMove = new Move { Name = MoveConstants.FastMoves._sandAttack, MoveType = MoveType.FastAttack, Type = PokemonType.Ground },
                ChargeMove1 = new Move { Name = MoveConstants.ChargeMoves._astonish, MoveType = MoveType.ChargeAttack, Type = PokemonType.Ghost},
                ChargeMove2 = new Move { Name = MoveConstants.ChargeMoves._suckerPunch, MoveType = MoveType.ChargeAttack, Type = PokemonType.Dark},
            },
        };
    }
}