using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    // PUBLIC na classe, significa que qualquer um pode instanciar minha classe Pessoa, neste caso aqui.
    public class Pessoa
    {
        // Criado mais um construtor. Não tem limite de construtores, podemos usar o tanto que achar necessário, neste caso, tem um que é vazio e outro que recebe parâmetro.
        public Pessoa()
        {

        }
        // Criado um construtor. Todo construtor tem o mesmo nome da sua classe.
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            // Variável (nome) recebe a propriedade (Nome) e o mesmo processo acontece com sobrenome.
            nome = Nome;
            sobrenome = Sobrenome;
        }

        // PRIVATE na propriedade, significa que tem restrições, neste caso apenas a classe Pessoa pode acessar está propriedade _nome. É conhecido como encapsulamento efetuando uma proteção a este campo, neste caso o campo _nome de alterações externas para podermos fazer validações, antes de atribuir um valor==value para ela.
        private string _nome;
        // _nome e _idade são campos, pois não usam get e set;
        private int _idade;
        // PUBLIC na propriedade, significa que qualquer um pode acessar está minha propriedade, ou seja, sem restrições.
        public string Nome
        {
            /* 
            get {
                return _nome.ToUpper();
            }
            */
            // Body Expression. Usado quando é um retorno muito simples de uma única linha.
            get => _nome.ToUpper();
            set
            {
                // Passará por uma validação.
                if (value == "")
                {
                    // Throw significa jogar para fora.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        // NomeCompleto é uma propriedade apenas de get, usado Body Expression. Foi combinado outras propriedades em apenas uma propriedade, com o método ToUpper(). Ou seja, foi transformado apenas para leitura, não pode ser atribuída outros valores para ela.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        // Nome e Idade são propriedades, pois usam get e set. Em alguns casos pode ser usado apenas um deles, mas sempre será usado get ou set nas propriedades.
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}