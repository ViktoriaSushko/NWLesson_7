using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NWLesson_7
{
    public class CurrencyItem
    {
        [JsonPropertyName("ccy")]
        public string Ccy { get; set; }
        [JsonPropertyName("base_ccy")]
        public string Base_ccy { get; set; }
        [JsonPropertyName("buy")]
        public string Buy { get; set; }
        [JsonPropertyName("sale")]
        public string Sale { get; set; }
        [JsonIgnore]
        public string Description => $"1{Ccy} = {Sale}{Base_ccy}";
    }
}
