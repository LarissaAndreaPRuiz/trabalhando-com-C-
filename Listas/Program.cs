using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProduto = new List<Produto>();
            listaProduto.Add(new Produto { Id = 1, Nome= "Bolacha", Preco= 1.5M   });
            listaProduto.Add(new Produto { Id = 2, Nome = "Salgado", Preco = 2.5M });
            listaProduto.Add(new Produto { Id = 3, Nome = "Pão", Preco = 3.5M });
            listaProduto.Add(new Produto { Id = 4, Nome = "Margarina", Preco = 5.0M });

            foreach (var p in listaProduto)
            {
                if (p.Preco > 5)
                {
                    Console.WriteLine($"{p.Nome} - {p.Preco}");
                }
            }
            Console.WriteLine("Where");
            var produtoMaior5 = listaProduto.Where(w => w.Preco && w.Id>0 > 5);
            foreach (var p in produtoMaior5)
            {
                Console.WriteLine($"{p.Nome} - {p.Preco}");
            }
        }
    }
}
            //double[] valorD = { 10.5, 11.5, 12.5 };

            //var lista = new List <string> ();
            //lista.Add("Carlos");
            //lista.Add("C#");

            //var indice = lista.IndexOf("C#");
            //lista.Remove("C#");

            //var dict = new Dictionary<int, int>();
            //dict.Add(1, 1);
            //dict.Add(4, 4);

