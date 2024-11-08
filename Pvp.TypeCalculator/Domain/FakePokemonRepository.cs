using Pvp.TypeCalculator.Constants;
using Pvp.TypeCalculator.DTOs;

namespace Pvp.TypeCalculator.Domain;

public class FakePokemonRepository : IPokemonRepository
{
    public Task CreatePokemon(PokemonDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task<PokemonDTO> DeletePokemon(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PokemonDTO> GetPokemon(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PokemonDTO>> GetPokemon(List<int> ids)
    {
        var dtos = new List<PokemonDTO>
        {
            new PokemonDTO{Id = 1, Name = PokemonConstants.Names._bulbasaur, FastMove = MoveConstants.FastMoves._vineWhip, ChargeMove = MoveConstants.ChargeMoves._tackle, Type1 = Enums.PokemonType.Grass, Type2 = Enums.PokemonType.Poison},
            new PokemonDTO{Id = 50, Name = PokemonConstants.Names._diglett, FastMove = MoveConstants.FastMoves._sandAttack, ChargeMove = MoveConstants.ChargeMoves._astonish, Type1 = Enums.PokemonType.Ground},
        };
        
        return await Task.FromResult(dtos.Where(x => ids.Contains(x.Id)).ToList());
    }

    public Task UpdatePokemon(PokemonDTO dto)
    {
        throw new NotImplementedException();
    }
}
