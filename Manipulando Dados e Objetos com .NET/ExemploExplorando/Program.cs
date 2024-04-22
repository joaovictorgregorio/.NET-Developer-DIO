using System.Collections;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using ExemploExplorando.Models;
using Newtonsoft.Json;

Console.Clear();

/* (Deserializando um objeto) */

// Está lendo o arquivo enviado.
string conteudoArquivo = File.ReadAllText("./Arquivos/vendas.json");

// Está sendo feito à deserializando o objeto.
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// Lendo todos os dados da lista.
foreach (Venda venda in listaVenda)
{
    Console.WriteLine(
        $"\nId: {venda.Id}, \nProduto: {venda.Produto}, \nPreco: {venda.Preco}, \nData: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


/* (Serialização de arquivo)
// ISO 8601 fornece um padrão globalmente reconhecido e amplamente utilizado para representar datas e horários de forma consistente e precisa em sistemas e documentos. Exemplo: "DataVenda": "2024-04-22T16:13:44.4338566-03:00".
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 105.50M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

// Acontece a serialização.
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Cria o arquivo JSON com os dados serializados.
File.WriteAllText("./Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
(Serialização de arquivo) */

/* (Descartes) até (IF Ternário)

int numero = 15;
bool ehPar = false;

// IF Ternário.
ehPar = numero % 2 == 0;

Console.ForegroundColor = ConsoleColor.DarkGreen; 
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é impar");
}

// (Descartes)

Pessoa p1 = new Pessoa("Joao Victor", "Gregorio");

// Chamando o desconstrutor.
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

(Descartes) até (IF Ternário) */



/* (Tupla em métodos) até (Descartes) 


LeituraArquivo arquivo = new LeituraArquivo();

// O método vai retornar uma tupla, por isso tantas declarações de variáveis aqui no var. Underline descarta a variável, está retornando, porém não está sendo usada.
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    // Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

(Tupla em métodos) até (Descartes) */


/* (Introdução) até (Outra sintaxe da tupla)

// Declaração de uma Tupla, está é a melhor forma. Pelo fato de poder nomear as variáveis.
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "João Victor", "Gregório da Silva", 1.85m);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(
    $"Id: {tupla.Id} \nNome: {tupla.Nome} \nSobrenome: {tupla.Sobrenome} \nAltura: {tupla.Altura}");

Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");

// Outra forma de declarar uma tupla...
ValueTuple<int, string, string, decimal, bool> outroExemploDeTupla = (5, "Larissa", "da Silva", 1.69m, true);
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(
    $"Id: {outroExemploDeTupla.Item1} \nNome: {outroExemploDeTupla.Item2} \nSobrenome: {outroExemploDeTupla.Item3} \nAltura: {outroExemploDeTupla.Item4} \nBooleano: {outroExemploDeTupla.Item5}");

Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.DarkBlue;
var maisUmExemploDeTupla = Tuple.Create(9, "Marisa", "Fernandez da Costa", 1.72m, false);
Console.WriteLine($"Id: {maisUmExemploDeTupla.Item1} \nNome: {maisUmExemploDeTupla.Item2} \nSobrenome: {maisUmExemploDeTupla.Item3} \nAltura: {maisUmExemploDeTupla.Item4} \nBooleano: {maisUmExemploDeTupla.Item5}");

(Introdução) até (Outra sintaxe da tupla) */



/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados) {
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("------------------");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados) {
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("=====================");

// Verificando se o elemento existe no Dictionary. 
string chave = "MG";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)) {
    Console.WriteLine($"Valor existente: {chave}");
}
else {
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}
*/


/*
Stack<int> pilha = new Stack<int>();

// Irá agrupar como uma piha, um encima do outro.
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);

foreach(int item in pilha) {
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(item);
}

// Método Pop(), irá remover o elemento do topo da pilha.
Console.WriteLine($"Removendo elemento do topo: {pilha.Pop()}");

// Adiciona o elemento ao topo da pilha.
pilha.Push(199);

foreach(int item in pilha) {
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(item);
}
*/

/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

Console.Clear();

foreach(int item in fila) {
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(12);

foreach(int item in fila) {
    Console.WriteLine(item);
}
/*

// new ExemploExcecao().Metodo1();

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