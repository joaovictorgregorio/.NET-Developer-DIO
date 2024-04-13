using ExemploExplorando.Models;

Console.Clear();

Pessoa pessoaUm = new Pessoa(nome: "João Victor", sobrenome: "Gregório");
// pessoaUm.Nome = "João Victor";
// pessoaUm.Sobrenome = "Gregório";

Pessoa pessoaDois = new Pessoa(nome:"Larissa", sobrenome:"Ferreira");
// pessoaDois.Nome = "Larissa";
// pessoaDois.Sobrenome = "Ferreira";

Pessoa pessoaTres = new Pessoa(nome:"Jaqueline", sobrenome:"Martins");

Pessoa pessoaQuatro = new Pessoa(nome:"Matheus", sobrenome:"Fernandez da Silva");

Curso cursoDeIngles = new Curso(nomedocurso:"Inglês");
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(pessoaUm);
cursoDeIngles.AdicionarAluno(pessoaDois);
cursoDeIngles.ListarAlunos();

Curso cursoDeEspanhol = new Curso(nomedocurso:"Espanhol");
cursoDeEspanhol.Alunos = new List<Pessoa>();
cursoDeEspanhol.AdicionarAluno(pessoaTres);
cursoDeEspanhol.AdicionarAluno(pessoaQuatro);
cursoDeEspanhol.ListarAlunos();
