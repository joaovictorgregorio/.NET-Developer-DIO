using ExemploFundamentos.Models;



/* Diferença entre Convert e Parse, recomendado usar Convert, pois ele retornará o valor 0 quando for nulo e manterá o código em execução, o Parse dará erro quando for passado nulo.

int a = Convert.ToInt32(null);
int b = int.Parse(null);
Console.WriteLine(a);
Console.WriteLine(b);
*/

// Informa a data atual do computador e horário atual
DateTime dataAtual = DateTime.Now.AddDays(8);

Console.WriteLine($"{dataAtual.ToString("dd/MM/yyyy HH:mm")}");

/*
Pessoa pessoa1 = new Pessoa();

pessoa1.Name = "João Victor";
pessoa1.Age = 24;
pessoa1.Apresentar();
*/