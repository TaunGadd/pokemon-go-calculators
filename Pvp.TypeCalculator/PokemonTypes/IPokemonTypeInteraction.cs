using Pvp.TypeCalculator.Moves;

namespace Pvp.TypeCalculator.PokemonTypes;

public interface IPokemonTypeInteraction
{
    double GetAttackRating(Move attackMove, Pokemon target);
}