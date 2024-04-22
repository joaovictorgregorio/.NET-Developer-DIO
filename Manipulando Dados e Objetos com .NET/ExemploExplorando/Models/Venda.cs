using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        // Utilizando atributos. Está informando um determinado comportamento diferente.
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}