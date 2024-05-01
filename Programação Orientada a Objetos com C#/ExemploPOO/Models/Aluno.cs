using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        // Dá a opção de não passar nenhuma informação na instância.
        public Aluno()
        {
            
        }
        // Obriga a passar o nome na instância, e joga para a Classe pai que é Pessoa.
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine(
                $"Olá, meu nome é {Nome} eu tenho {Idade} anos e minha nota é de {Nota} pontos."
            );
        }
    }
}