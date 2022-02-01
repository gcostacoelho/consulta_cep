using Newtonsoft.Json;

namespace consAPI
{
    public class cep_resp
    {
        [JsonProperty("cep")]
        public string? Cep { get; set; }
        [JsonProperty("logradouro")]
        public string? Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string? Complemento { get; set; }
        [JsonProperty("bairro")]
        public string? Bairro { get; set; }
        [JsonProperty("uf")]
        public string? Uf { get; set; }
        [JsonProperty("localidade")]
        public string? Localidade { get; set; }
        [JsonProperty("ibge")]
        public string? Ibge { get; set; }

    }
}