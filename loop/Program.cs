//Loop for

int soma = 0, i = 0, j = 0, k = 0;

for (i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (i = 1; i <= 100; i++)
{
    soma += i; //Soma o valor de i à variável soma, exemplo: 1+2+3+4.. e etc
    
}

Console.WriteLine($"\nA soma dos números de 1 a 100 é: {soma}\n");

//Loop While

while (j <= 5)
{
    Console.WriteLine($"{j++}");
    
}

j = 0;
//Loop Do-While
do {
    Console.WriteLine($"{k++}");

} while(k <= 5);

//Loop Foreach

List<string> nomes = new List<string> { "Elisa", "Antonio", "Carlos", "Marcelo" };

//Usando o foreach para percorrer a lista
foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}"); //Imprime cada nome exibindo na tela
}

// Um vetor de números inteiros
int[] numeros = { 59, 22, 26, 48 };

//Usando o foreach para percorrer o vetor
foreach (int numero in numeros)
{
    Console.WriteLine($"{numero}"); //Imprime cada número exibindo na tela
}