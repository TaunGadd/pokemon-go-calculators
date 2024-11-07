using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Calculator;

public interface IPokemonTypeInteraction
{
    Task<double> GetAttackRating(Move attackMove, Pokemon target);
}