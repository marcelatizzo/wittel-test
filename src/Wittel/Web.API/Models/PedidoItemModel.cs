﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.API.Models
{
    public class PedidoItemModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "descricao")]
        public string Descricao { get; set; }

        [JsonProperty(PropertyName = "produto-id")]
        public int ProdutoId { get; set; }

        [JsonProperty(PropertyName = "valor-unitario")]
        public decimal ValorUnitario { get; set; }

        [JsonProperty(PropertyName = "qtd")]
        public decimal Quantidade { get; set; }

        [JsonProperty(PropertyName = "valor-total")]
        public decimal ValorTotal { get; set; }
    }
}