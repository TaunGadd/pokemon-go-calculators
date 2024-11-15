using AsGuard.Api.Validator;
using Pvp.TypeCalculator.Domain;
using Pvp.TypeCalculator.DTOs;
using Pvp.TypeCalculator.Mappers;
using Pvp.TypeCalculator.Models;

namespace Pvp.TypeCalculator.Services;

public class BattleService : IBattleService
{
    private readonly IMoveMapper _moveMapper;
    private readonly IMoveRepository _moveRepository;
    private readonly IPokemonMapper _pokemonMapper;
    private readonly IPokemonRepository _pokemonRepository;

    public BattleService(
        IMoveMapper moveMapper,
        IMoveRepository moveRepository,
        IPokemonMapper pokemonMapper,
        IPokemonRepository pokemonRepository 
        )
    {
        _moveMapper = moveMapper;
        _moveRepository = moveRepository;
        _pokemonMapper = pokemonMapper;
        _pokemonRepository = pokemonRepository;
    }

    public async Task<BattleResultDTO> Battle(int attackerId, int defenderId)
    {
        Guard.Against
            .NegativeOrZeroValue(attackerId, nameof(attackerId))
            .NegativeOrZeroValue(defenderId, nameof(defenderId));

        var pokemonDTOs = await _pokemonRepository.GetPokemon(new List<int> { attackerId, defenderId });

        var attackingPokemon = await GeneratePokemon(attackerId, pokemonDTOs);
        var defendingPokemon = await GeneratePokemon(defenderId, pokemonDTOs);

        return await attackingPokemon.Attack(defendingPokemon);
    }

    private async Task<Pokemon> GeneratePokemon(int id, List<PokemonDTO> pokemonDTOs)
    {
        var attackingPokemonDTO = pokemonDTOs.First(x => x.Id == id);
        var attackerFM = await _moveRepository.GetMove(attackingPokemonDTO.FastMove);
        var attackerCM1 = await _moveRepository.GetMove(attackingPokemonDTO.ChargeMove1);
        var attackerCM2 = await _moveRepository.GetMove(attackingPokemonDTO.ChargeMove2);
        var attackerMoveSet = new MoveSet
        {
            FastMove = _moveMapper.Map(attackerFM),
            ChargeMove1 = _moveMapper.Map(attackerCM1),
            ChargeMove2 = _moveMapper.Map(attackerCM2)
        };
        return _pokemonMapper.Map(attackingPokemonDTO, attackerMoveSet);
    }
}
