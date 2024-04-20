using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        // Neste método está sendo retornado uma Tupla com 3 tipos de variáveis diferentes.
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                // O retorno precisa seguir a ordem da Tupla, neste caso, irá retornar um booleano, um array e um inteiro.
                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }
        }
    }
}