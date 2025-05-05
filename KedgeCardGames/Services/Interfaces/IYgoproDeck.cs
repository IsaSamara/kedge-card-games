using KedgeCardGames.Dtos;
using Refit;

namespace KedgeCardGames.Services.Interfaces
{
    public interface IYgoproDeck
    {
        [Get("/v7/cardinfo.php")]
        Task<RepostaCartasYuGiOhDto> ObterCardsYuGiOh(
            [AliasAs("num")] int pageSize = 1,
            [AliasAs("offset")] int page = 20,
            [AliasAs("fname")] string? query = null);
    }
}
