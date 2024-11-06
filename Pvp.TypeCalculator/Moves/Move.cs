﻿using Pvp.TypeCalculator.PokemonTypes;

namespace Pvp.TypeCalculator.Moves
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