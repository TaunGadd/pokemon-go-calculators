namespace Pvp.TypeCalculator.Models
{
    public class Move
    {
        public string Name { get; }
        public PokemonType Type { get; }

        public Move(string name, PokemonType type)
        {
            Name = name;
            Type = type;
        }
    }
}