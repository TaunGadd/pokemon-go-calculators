using Pvp.TypeCalculator.Moves;
using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator;

// TODO add DI and refactor
public class Pokemon
{
    public string Name { get; }
    public PokemonType Type1 { get; }
    public PokemonType Type2 { get; }
    public MoveSet MoveSet { get; }
    public bool IsDualType => Type1 != Type2;

    public IPokemonTypeInteraction _typeInteraction;

    public Pokemon(string name, MoveSet moveSet, PokemonType type) : this(name, moveSet, type, type)
    {
    }

    public Pokemon(string name, MoveSet moveSet, PokemonType type1, PokemonType type2) 
    {
        Name = name;
        MoveSet = moveSet;
        Type1 = type1;
        Type2 = type2;

        // Temporary, use DI
        _typeInteraction = new StandardInteraction();
    }

    public double Attack(Pokemon target)
    {
        var attackRating = _typeInteraction.GetAttackRating(MoveSet.FastMove, target) + _typeInteraction.GetAttackRating(MoveSet.ChargeMove, target);
        var defenseRating = _typeInteraction.GetAttackRating(target.MoveSet.FastMove, this) + _typeInteraction.GetAttackRating(target.MoveSet.ChargeMove, this);

        return attackRating - defenseRating;
    }

}
