using System;

namespace Genéricos
{
    class Program
    {
        static void Main(string[] args)
        {
            var repVendedor = new Repositorio<Vendedor>();
            var repProduto = new Repositorio<Produto>();

            repVendedor.Incluir(new Vendedor { Id = 1, Nome = "Marcia" });
            repProduto.Incluir(new Produto { Id = 2, Descricao = "Batata", Preco = 3.8M });
            {

            }
        }
    }
}
