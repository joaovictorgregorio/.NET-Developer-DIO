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
            Console.WriteLine($"\nAlunos do curso de: {NomeDoCurso}\n");
            foreach(Pessoa aluno in Alunos) {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}