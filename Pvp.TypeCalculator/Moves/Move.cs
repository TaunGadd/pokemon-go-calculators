using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.Moves
{
    public class Move
    {
        public string Name { get; }
        public PokemonType Type { get; }
        public MoveType MoveType { get; }

        public Move(string name, PokemonType type, MoveType moveType)
        {
            Name = name;
            Type = type;
            MoveType = moveType;
        }
    }
}