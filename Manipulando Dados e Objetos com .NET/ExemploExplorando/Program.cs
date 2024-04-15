using System.Globalization;
using System.Security.AccessControl;
using ExemploExplorando.Models;

new ExemploExcecao().Metodo1();



















/*
// Try = tente fazer alguma coisa.
try {
    Console.Clear();
    string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivoLeitura.txt");

    foreach(string linha in linhas) {
        Console.WriteLine(linha);
    }
}
catch(FileNotFoundException erro) {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Erro na leitura do arquivo. Arquivo não encontrado! {erro.Message}");
}
catch(DirectoryNotFoundException erro) {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Erro na leitura do arquivo. Caminho da pasta não encontrado! {erro.Message}");
}
// catch = pegar/obter. Usado para fazer tratamentos de erros.
catch(Exception erro) {
    Console.WriteLine($"Erro genérico. {erro.Message}");
}
// Sempre é executado mesmo tendo erro ou não.
finally {
    Console.WriteLine($"Chegou até aqui...");
}
*/

/*
string dataString = "2024-12-14 19:41";

// Formato para evitar o encerramento do programa, caso os dados da data seja passado de forma incorreta.
bool sucesso = DateTime.TryParseExact(
    dataString, "yyyy-MM-dd HH:mm", 
    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

    if (sucesso) {
        WriteLine($"Conversão com sucesso! Data: {data}");
    }
    else {
        WriteLine($"{dataString} não é uma data válida!");
    }

WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
WriteLine(data.ToShortTimeString());
WriteLine(data.ToShortDateString());
WriteLine(data);
*/

/*
// Uma forma de usar a cultura do país em todo o sistema.
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Console.Clear();

decimal valorMonetario = 1582.40m;

// Significa que quero formatar a string para uma moeda. Segue a cultura do meu sistema/máquina.
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
// Representando quantidade de casas decimais, neste caso 3.
Console.WriteLine(valorMonetario.ToString("C3"));
Console.WriteLine(valorMonetario.ToString("N0"));
*/

/*
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);
*/

/*
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
*/