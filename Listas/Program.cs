using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração e criação da lista
            List<string> ListaAutores = new List<string>();

            //Adicionar itens na lista
            ListaAutores.Add("Marcio de Andrade");
            ListaAutores.Add("Giovanna Rufini de Andrade");
            ListaAutores.Add("Milena Rufini de Andrade");

            //para exibir os itens pe necessário percorrer a lista
            foreach (string autor in ListaAutores)
            {
                Console.WriteLine(autor);
            }

            Console.WriteLine("=== Outra lista == ");

            //Forma alternativa podemos passar uma Array para criar a lista de objetos
            string[] autores = { "Angela", "Marcelo", "José", "João", "Maria" };

            List<string> ranking = new List<string>(autores);

            foreach(string escritores in autores)
            {
                Console.WriteLine(escritores);
            }


            //Criando uma lista to tipo inteiro
            List<int> ListaIdades = new List<int>();
            ListaIdades.Add(35);
            ListaIdades.Add(51); 
            ListaIdades.Add(22); 
            ListaIdades.Add(15);
            ListaIdades.Add(48);

            
        }
    }
}
