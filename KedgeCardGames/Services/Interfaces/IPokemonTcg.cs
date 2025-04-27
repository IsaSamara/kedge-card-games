using KedgeCardGames.Dtos;
using Refit;

namespace KedgeCardGames.Services.Interfaces
{
    public interface IPokemonTcg
    {
        [Get("/v2/cards")]
        Task<RespostaCartasPokemonDto> ObterCardsPokemon(
            [AliasAs("page")] int page = 1, 
            [AliasAs("pageSize")] int pageSize = 20,
            [AliasAs("q")] string? query = null);
    }
}
