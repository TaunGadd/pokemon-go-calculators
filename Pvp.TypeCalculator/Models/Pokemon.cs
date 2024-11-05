namespace Pvp.TypeCalculator.Models
{
    public class Pokemon
    {
        public string Name { get; }
        public PokemonType Type1 { get; }
        public PokemonType Type2 { get; }
        public MoveSet MoveSet { get; }

        public Pokemon(string name, MoveSet moveSet, PokemonType type)
        {
            Name = name;
            Type1 = type;
            Type2 = type;
        }

        public Pokemon(string name, MoveSet moveSet, PokemonType type1, PokemonType type2)
        {
            Name = name;
            Type1 = type1;
            Type2 = type2;
        }

        public bool IsDualType => Type1 != Type2;
    }
}
