using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.API.Models
{
    public class PedidoModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "data")]
        public DateTime DataPedido { get; set; }

        [JsonProperty(PropertyName = "descricao")]
        public string Descricao { get; set; }

        [JsonProperty(PropertyName = "itens")]
        public List<PedidoItemModel> ItensPedido { get; set; }

        [JsonProperty(PropertyName = "valor-total")]
        public decimal ValorTotalPedido { get; set; }
    }
}