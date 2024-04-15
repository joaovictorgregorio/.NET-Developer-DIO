using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models {
    public class Curso {
        public Curso(string nomedocurso) {
            NomeDoCurso = nomedocurso;
        }
        public string NomeDoCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno) {
            // O retorno foi usado aqui, pois o Remove retorna um Booleano, sendo compatível com o tipo do nosso método.
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos() {
            // Usando concatenação.
            Console.WriteLine("\nAlunos do curso de: " + NomeDoCurso);

            for(int i = 0; i < Alunos.Count; i++) {
                // Usando interpolação.
                string texto = $"N°{i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}