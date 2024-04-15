using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models {
    public class Pessoa {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar() {
            Console.Clear();
            Console.WriteLine($"Olá, eu sou {Name} e tenho {Age} anos!");
        }
    }
}