using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CurencyJSONDTO
    {
        [JsonProperty("r030")]
        public int Id { get; set; }
        [JsonProperty("txt")]
        public string NameRus { get; set; }
        [JsonProperty("rate")]
        public decimal Rate { get; set; }
        [JsonProperty("cc")]
        public string Name { get; set; }
        [JsonProperty("exchangedate")]
        public string ExchangeDate { get; set; }
    }
}
