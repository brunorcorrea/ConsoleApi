using Newtonsoft.Json;

namespace ConsoleApi
{
    public class ApiResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("curso")]
        public string Curso { get; set; }
        
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
        
        [JsonProperty("ano")]
        public int Ano { get; set; }
        
        [JsonProperty("periodo")]
        public string Periodo { get; set; }
    }
}
