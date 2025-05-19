using KedgeCardGames.Dtos.Interfaces;

namespace KedgeCardGames.Services
{
    public static class WishlistService
    {
        private static readonly List<ICartaDesejo> _cartas = new();

        public static IReadOnlyList<ICartaDesejo> Cartas => _cartas;

        public static void Adicionar(ICartaDesejo carta)
        {
            if (!_cartas.Any(c => c.Id == carta.Id && c.Origem == carta.Origem))
                _cartas.Add(carta);
        }

        public static void Remover(string id, string origem)
        {
            _cartas.RemoveAll(c => c.Id == id && c.Origem == origem);
        }
    }
}
