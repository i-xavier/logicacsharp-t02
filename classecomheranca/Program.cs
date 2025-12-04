using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica14
{
    //Classe base (superclasse)
    internal class Animal
    {
        // Propriedade da classe Animal
        public string Nome {  get; set; }

        // Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal {Nome} emite um som.");
        }
    }

    // Classe derivada (subclasse) 

    internal class Cachorro : Animal
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

    internal class Gato : Animal
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias das classes derivadas
            Animal a1 = new Cachorro { Nome = "Dumbo" };
            Animal a2 = new Gato { Nome = "Nino" };
            Animal a3 = new Animal { Nome = "Lulu" };

            // Chamando o método EmitirSom para cada animal
            /*
            a1.EmitirSom(); 
            a2.EmitirSom();
            a3.EmitirSom();*/

            // Utilizando Polimorfismo: Array de animais
            Animal[] animais = { a1, a2, a3 };

            foreach (var animal in animais)
            {
                animal.EmitirSom(); //Cada objeto chama o método adequado de sua classe
            }
        }
    }

}
