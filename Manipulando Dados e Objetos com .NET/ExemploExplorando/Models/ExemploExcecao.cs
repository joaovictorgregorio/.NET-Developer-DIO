using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models {
    public class ExemploExcecao {
        public void Metodo1() {      
            try {
                Metodo2();
            }      
            catch(Exception erro) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                // StackTrace = mostra o caminho que o sistema fez para chegar até aqui.
                Console.WriteLine($"Erro corrigido. {erro.StackTrace}");
            }
        }

        public void Metodo2() {            
            Metodo3();
        }

        public void Metodo3() {            
            Metodo4();
        }

        public void Metodo4() {         
            // throw = jogue para cima/jogue de volta. A leitura é feita de baixo para cima, ele irá tentar encontrar a estrutura catch.
            throw new Exception($"Ocorreu uma exceção!");
        }
    }
}