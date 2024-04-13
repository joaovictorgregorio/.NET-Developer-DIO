using ExemploExplorando.Models;

Console.Clear();

Pessoa pessoaUm = new Pessoa();
pessoaUm.Nome = "João Victor";
pessoaUm.Sobrenome = "Gregório";

Pessoa pessoaDois = new Pessoa();
pessoaDois.Nome = "Larissa";
pessoaDois.Sobrenome = "Ferreira";

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeDoCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(pessoaUm);
cursoDeIngles.AdicionarAluno(pessoaDois);
cursoDeIngles.ListarAlunos();

