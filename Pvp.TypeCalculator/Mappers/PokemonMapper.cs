﻿using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Mappers;

public class PokemonMapper : IPokemonMapper
{
    public PokemonDTO Map(Pokemon pokemon)
    {
        return new PokemonDTO
        {
            Id = pokemon.Id,
            Name = pokemon.Name,
            Type1 = pokemon.Type1,
            Type2 = pokemon.Type2,
            FastMove = pokemon.MoveSet.FastMove.Name,
            ChargeMove = pokemon.MoveSet.ChargeMove.Name,
        };
    }

    public Pokemon Map(PokemonDTO pokemon, MoveSet moveSet)
    {
        return new Pokemon
        {
            Id = pokemon.Id,
            Name = pokemon.Name,
            Type1 = pokemon.Type1,
            Type2 = pokemon.Type2 ?? pokemon.Type1,
            MoveSet = moveSet
        };
    }
}