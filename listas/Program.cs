using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> nomes = new List<string>();

        // Adicionando elementos
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine("\nLista após adicionar elementos: \n");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Adicionando novo nome
        nomes.Add("Daniel");

        Console.WriteLine("\nLista após adicionar 'Daniel': \n");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Removendo elementos
        nomes.Remove("Bruno");

        Console.WriteLine("\nLista após remover 'Bruno': \n");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        
        //Removendo pelo índicie
        nomes.RemoveAt(0);

        Console.WriteLine("\nLista após remover o índice 0 (Ana): \n");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Limpando toda a lista
        Console.WriteLine("\nLista antes do Clear(): ");
        Console.WriteLine("Quantidade de elementos: " + nomes.Count);
        nomes.Clear();

        Console.WriteLine("\nLista após Clear(): ");
        Console.WriteLine("Quantidade de elementos: " +  nomes.Count);
    }
}