using System.Text.Json.Serialization;

namespace KedgeCardGames.Dtos
{
    public class RespostaCartasPokemonDto
    {
        [JsonPropertyName("data")]
        public List<CartaPokemonDto> Cartas { get; set; }
    }

    public class CartaPokemonDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("supertype")]
        public string Supertipo { get; set; }

        [JsonPropertyName("subtypes")]
        public List<string> Subtipos { get; set; }

        [JsonPropertyName("hp")]
        public string Hp { get; set; }

        [JsonPropertyName("types")]
        public List<string> Tipos { get; set; }

        [JsonPropertyName("evolvesFrom")]
        public string EvoluiDe { get; set; }

        [JsonPropertyName("attacks")]
        public List<AtaqueDto> Ataques { get; set; }

        [JsonPropertyName("weaknesses")]
        public List<FraquezaDto> Fraquezas { get; set; }

        [JsonPropertyName("resistances")]
        public List<FraquezaDto> Resistencias { get; set; }

        [JsonPropertyName("retreatCost")]
        public List<string> CustoRetirada { get; set; }

        [JsonPropertyName("convertedRetreatCost")]
        public int CustoRetiradaConvertido { get; set; }

        [JsonPropertyName("set")]
        public ConjuntoDto Conjunto { get; set; }

        [JsonPropertyName("number")]
        public string Numero { get; set; }

        [JsonPropertyName("artist")]
        public string Artista { get; set; }

        [JsonPropertyName("rarity")]
        public string Raridade { get; set; }

        [JsonPropertyName("flavorText")]
        public string Descricao { get; set; }

        [JsonPropertyName("nationalPokedexNumbers")]
        public List<int> Pokedex { get; set; }

        [JsonPropertyName("images")]
        public ImagensDto Imagens { get; set; }

        [JsonPropertyName("cardmarket")]
        public MercadoCarta MercadoCartas { get; set; }
    }

    public class MercadoCarta
    {
        [JsonPropertyName("prices")]
        public Preco Precos { get; set; }
    }

    public class Preco
    {
        [JsonPropertyName("lowPrice")]
        public decimal MenorPreco { get; set; }
    }

    public class AtaqueDto
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("cost")]
        public List<string> Custo { get; set; }

        [JsonPropertyName("convertedEnergyCost")]
        public int CustoConvertido { get; set; }

        [JsonPropertyName("damage")]
        public string Dano { get; set; }

        [JsonPropertyName("text")]
        public string Descricao { get; set; }
    }

    public class FraquezaDto
    {
        [JsonPropertyName("type")]
        public string Tipo { get; set; }

        [JsonPropertyName("value")]
        public string Valor { get; set; }
    }

    public class ConjuntoDto
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("series")]
        public string Serie { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("images")]
        public ImagensConjuntoDto Imagens { get; set; }
    }

    public class ImagensDto
    {
        [JsonPropertyName("small")]
        public string Pequena { get; set; }

        [JsonPropertyName("large")]
        public string Grande { get; set; }
    }

    public class ImagensConjuntoDto
    {
        [JsonPropertyName("symbol")]
        public string Simbolo { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }   
}
