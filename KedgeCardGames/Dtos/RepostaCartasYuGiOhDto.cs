using KedgeCardGames.Dtos.Interfaces;
using System.Text.Json.Serialization;

namespace KedgeCardGames.Dtos
{
    public class RepostaCartasYuGiOhDto
    {
        [JsonPropertyName("data")]
        public List<CartaYgoDto> Cartas { get; set; }
    }

    public class CartaYgoDto : ICartaDesejo
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("type")]
        public string Tipo { get; set; }

        [JsonPropertyName("humanReadableCardType")]
        public string TipoHumano { get; set; }

        [JsonPropertyName("frameType")]
        public string Moldura { get; set; }

        [JsonPropertyName("desc")]
        public string Descricao { get; set; }

        [JsonPropertyName("race")]
        public string Raca { get; set; }

        [JsonPropertyName("archetype")]
        public string Arquétipo { get; set; }

        [JsonPropertyName("ygoprodeck_url")]
        public string UrlYgoProDeck { get; set; }

        [JsonPropertyName("card_sets")]
        public List<ConjuntoCartaYgoDto> Conjuntos { get; set; }

        [JsonPropertyName("card_images")]
        public List<ImagemCartaYgoDto> Imagens { get; set; }

        [JsonPropertyName("card_prices")]
        public List<PrecoCartaYgoDto> Precos { get; set; }

        string ICartaDesejo.Id => this.Id.ToString();
        string ICartaDesejo.Nome => this.Nome;
        string ICartaDesejo.ImagemUrl => this.Imagens?.FirstOrDefault()?.UrlImagem ?? "";
        string ICartaDesejo.Origem => "Yugioh";
    }

    public class ConjuntoCartaYgoDto
    {
        [JsonPropertyName("set_name")]
        public string NomeConjunto { get; set; }

        [JsonPropertyName("set_code")]
        public string CodigoConjunto { get; set; }

        [JsonPropertyName("set_rarity")]
        public string Raridade { get; set; }

        [JsonPropertyName("set_rarity_code")]
        public string CodigoRaridade { get; set; }

        [JsonPropertyName("set_price")]
        public string Preco { get; set; }
    }

    public class ImagemCartaYgoDto
    {
        [JsonPropertyName("id")]
        public long IdImagem { get; set; }

        [JsonPropertyName("image_url")]
        public string UrlImagem { get; set; }

        [JsonPropertyName("image_url_small")]
        public string UrlImagemPequena { get; set; }

        [JsonPropertyName("image_url_cropped")]
        public string UrlImagemCortada { get; set; }
    }

    public class PrecoCartaYgoDto
    {
        [JsonPropertyName("cardmarket_price")]
        public string PrecoCardMarket { get; set; }

        [JsonPropertyName("tcgplayer_price")]
        public string PrecoTcgPlayer { get; set; }

        [JsonPropertyName("ebay_price")]
        public string PrecoEbay { get; set; }

        [JsonPropertyName("amazon_price")]
        public string PrecoAmazon { get; set; }

        [JsonPropertyName("coolstuffinc_price")]
        public string PrecoCoolStuffInc { get; set; }
    }
}
