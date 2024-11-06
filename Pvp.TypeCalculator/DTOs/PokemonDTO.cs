using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.DTOs
{
    public class PokemonDTO
    {
        public int Id;
        public required string Name;
        public required PokemonType Type1;
        public PokemonType? Type2;
        public required string FastMove;
        public required string ChargeMove;
    }
}