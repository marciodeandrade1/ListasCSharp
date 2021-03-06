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


            Console.WriteLine("=== Contagem de itens da Lista de Inteiros ====");
            //Criando uma lista to tipo inteiro
            List<int> ListaIdades = new List<int>();
            ListaIdades.Add(35);
            ListaIdades.Add(51); 
            ListaIdades.Add(22); 
            ListaIdades.Add(15);
            ListaIdades.Add(48);

            //Exibe contagem de itens
            Console.WriteLine("Contagem: {0}", ListaIdades.Count);


            //A propriedade Capacity recebe e define o número de itens que uma lista pode conter sem redimensionar.
            //A capacidade é sempre maior ou igual ao valor da Contagem.


            Console.WriteLine("=== Capacity ===");
            List<string> ListaDeAutores = new List<string>();

            //Adicionar itens na lista
            ListaDeAutores.Add("Marcio de Andrade");
            ListaDeAutores.Add("Giovanna Rufini de Andrade");
            ListaDeAutores.Add("Milena Rufini de Andrade");
            ListaDeAutores.Add("Sandra Marcia de Andrade");
            ListaDeAutores.Add("Alexandre Guilherme de Andrade");
            ListaDeAutores.Add("Maria Eduarda de Andrade Siqueira");
            ListaDeAutores.Add("Ian Meneguel de Andrade");
            ListaDeAutores.Add("Mariana Meneguel de Andrade");
            ListaDeAutores.Add("Vinicius Meneguel de Andrade");
            ListaDeAutores.Add("Sandro Andrade");

            //Original Capacity
            Console.WriteLine("Original Capacity: {0}", ListaDeAutores.Capacity);
            //Trim excess
            ListaDeAutores.TrimExcess();
            Console.WriteLine("Trimmed Capacity: {0}", ListaDeAutores.Capacity);
            //Update Capacity
            ListaDeAutores.Capacity = 20;
            Console.WriteLine(ListaDeAutores.Capacity);
            Console.WriteLine("Update Capacity: {0}", ListaDeAutores.Capacity);

            Console.WriteLine("=== Contagem ===");
            Console.WriteLine(" ");
            // Count
            Console.WriteLine("Count: {0} ", ListaDeAutores.Count);


            Console.WriteLine("=== Pega conteúdo da lista pelo índice ===");
            List<string> ListaDeNovosAutores = new List<string>();

            //Adicionar itens na lista
            ListaDeNovosAutores.Add("Marcio de Andrade");
            ListaDeNovosAutores.Add("Giovanna Rufini de Andrade");
            ListaDeNovosAutores.Add("Milena Rufini de Andrade");
            ListaDeNovosAutores.Add("Sandra Marcia de Andrade");
            ListaDeNovosAutores.Add("Alexandre Guilherme de Andrade");

            //Recebe o primeiro item da lista
            string novoautor = ListaDeNovosAutores[0];
            Console.WriteLine(novoautor);

            Console.WriteLine("=== Remove item da lista ===");
            //insere um range de itens
            string[] nomes = { "José", "João", "Catarina", "Angela" };

            ListaDeNovosAutores.InsertRange(4, nomes);


            foreach (string nome in ListaDeNovosAutores)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("=== Remove determinado Item da lista ===");
            Console.WriteLine(" ");
            ListaDeNovosAutores.Remove("Marcio de Andrade");
            foreach (string nome in ListaDeNovosAutores)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("=== Remove determinado Item pela posição ===");
            Console.WriteLine(" ");
            //remove item da posição 3
            ListaDeNovosAutores.RemoveAt(3);

            foreach (string nome in ListaDeNovosAutores)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("=== Remove determinado Item pelo Range ===");
            Console.WriteLine(" ");

            //remove 2 itens a partir da posição 4
            ListaDeNovosAutores.RemoveRange(4, 2);

            foreach (string nome in ListaDeNovosAutores)
            {
                Console.WriteLine(nome);
            }
            foreach (string nome in ListaDeNovosAutores)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("=== Pesquisa na lista ===");

            int itemPosicao = ListaDeNovosAutores.BinarySearch("Milena Rufini de Andrade");
            Console.WriteLine("Item encontrado na posição: {0}", itemPosicao + 1);

            Console.WriteLine("=== Ordenação da lista ===");
            Console.WriteLine("");
            Console.WriteLine("Lista Original");
            foreach(var autor in ListaDeNovosAutores)
            {
                Console.WriteLine(autor);
            }

            Console.WriteLine("");
            Console.WriteLine("Lista Ordenada");
            ListaDeNovosAutores.Sort();
            foreach (var autor in ListaDeNovosAutores)
            {
                Console.WriteLine(autor);
            }

        }
    }
}
