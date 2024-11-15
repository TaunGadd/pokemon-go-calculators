﻿using Pvp.TypeCalculator.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pvp.TypeCalculator.DTOs;

public class MoveDTO
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public PokemonType Type { get; set; }
    public MoveType MoveType { get; set; }
}
