using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Calculator;

public interface IPokemonTypeInteraction
{
    Task<double> InitiateAttack(Pokemon attacker, Pokemon defender);
}