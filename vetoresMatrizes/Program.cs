//Declaração de dois vetores
using System.Runtime.CompilerServices;


int[] numeros = { 7, 2, 3, 34, 5 }; //Vetor de inteiros
string[] nomes = { "Ana", "João", "Maria", "Carlos" }; //Vetor de string

//Exibindo os elementos do vetor de números com loop for
Console.WriteLine("Vetor de números (usando for):\n");
for (int i =0; i < numeros.Length; i++)
    Console.WriteLine($"{numeros[i]}\n");


//Exibindo os elementos do vetor de nomes com loop for
Console.WriteLine("Vetor de nomes (usando for):\n");
for ( int j = 0; j < nomes.Length; j++ )
    Console.WriteLine($"{nomes[j]}\n");

//Exibindo os elementos do vetor de nomes com foreach;
Console.WriteLine("Vetor de nomes (usando foreach):\n");
foreach (var nome in nomes) 
    Console.WriteLine(nome);

//Ordenação do vetor de números
/*Array.Sort(numeros);
Console.WriteLine("Vetor de Números Ordenados:\n");
foreach (var n in numeros) { 
    Console.WriteLine(n);
}*/

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);

if (posicaoSequencial != -1)
{
    Console.WriteLine($"Pesquisa Sequencial: Valor {valorProcurado} encontrado na posição {posicaoSequencial}"); 
}

else
    Console.WriteLine($"Pesquisa Sequencial: Valor {valorProcurado} não encontrado.");


static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i <vetor.Length; i++)
    {
        if (vetor[i] == valor)
            return i;
    }
    return -1;
}

