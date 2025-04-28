using KedgeCardGames.Dtos;
using Refit;

namespace KedgeCardGames.Services.Interfaces
{
    public interface IYgoproDeck
    {
        [Get("/v7/cardinfo.php")]
        Task<RepostaCartasYuGiOhDto> ObterCardsYuGiOh(
            [AliasAs("num")] int pageSize = 20,
            [AliasAs("offset")] int page = 0);
    }
}
