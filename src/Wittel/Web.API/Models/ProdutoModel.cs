using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.API.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "descricao")]
        public string Descricao { get; set; }

        [JsonProperty(PropertyName = "valor-unitario")]
        public decimal ValorUnitario { get; set; }

        [JsonProperty(PropertyName = "qtd-estoque")]
        public decimal QuantidadeEstoque { get; set; }
    }
}