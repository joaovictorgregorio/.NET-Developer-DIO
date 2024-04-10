using System.Reflection.Metadata;
using ExemploFundamentos.Common.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 99;
arrayInteiros[1] = 54;
arrayInteiros[2] = 102;
arrayInteiros[3] = 9999;

// Executa uma cópia do arrayInteiros para o arrayInteirosDobrado, pegando todas as informações necessárias.
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

/* Maneira de redimensionar o Array já em tempo de execução, quando não temos como mexer no código original. O Resize vai criar um novo Array com a capacidade que passamos, neste caso, vezes 2 do tamanho do original, ou seja, ele realiza uma cópia da referência e junta com a nova capacidade solicitada.
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); */

for(int contador = 0; contador < arrayInteiros.Length; contador++) {
    Thread.Sleep(200);
    Console.WriteLine($"Posição N°{contador} - {arrayInteiros[contador]}");
}

/* Console.WriteLine("");

int contadorForeach = 0;
foreach(int valor in arrayInteiros) {
    Thread.Sleep(200);
    Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
    contadorForeach++;
} */

/* Interrompendo o fluxo de execução

int numero = 5;
int contador = 1;

while (contador < 10) {
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 6) {
        break;
    }
}
*/

/*Calculadora calc = new Calculadora();

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(10);*/


/* Diferença entre Convert e Parse, recomendado usar Convert, pois ele retornará o valor 0 quando for nulo e manterá o código em execução, o Parse dará erro quando for passado nulo.

int a = Convert.ToInt32(null);
int b = int.Parse(null);
Console.WriteLine(a);
Console.WriteLine(b);
*/

/* Informa a data atual do computador e horário atual
DateTime dataAtual = DateTime.Now.AddDays(8);

Console.WriteLine($"{dataAtual.ToString("dd/MM/yyyy HH:mm")}");
*/

/*
Pessoa pessoa1 = new Pessoa();

pessoa1.Name = "João Victor";
pessoa1.Age = 24;
pessoa1.Apresentar();
*/