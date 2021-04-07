using System;
using System.Data.SqlClient;

namespace ClassesTryeDispose
{
 class Program
    {
    static void Main(string[] args)
        {
            var c = new Cliente();
            c.Id = 1;
            c.Nome = "Carlos";
            c.TipoPessoa = Tipo.Fornecedor;
        }

    }

}
        //static int x;
        //    int valor = 0;
        //    var s = "Maria"; valor.ToString();

        //    var valorVolta = 0;
        //    var dataStr = "01/01/2020";
        //    DateTime.TryParse(dataStr, out DateTime Data);
        //    int.TryParse(s, out valorVolta);
            //try
            //{
            //     valorVolta = int.Parse(s);
            //}
            //catch(FormatException ex)
            //{
            //    valorVolta = -1;
            //    Console.WriteLine($"Erro na conversao:{ ex.Message}");
            //}
    //        int b = 0;
    //        try
    //        {
    //            int c = 1 / b;
    //            Console.WriteLine("Codigo deois do erro");
    //        }
    //        catch (ArithmeticException ex)
    //        {
    //            Conso le.WriteLine("Erro matematico:" + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Erro geral:"+ex.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Finally");
    //        }
    //    }
    //    public static int Soma(int a, int b)
    //    {
    //        if (x == 0)
    //        {

    //        }
    //        return a + b;
    //    }
    //}

           // using(var con= new SqlConnection())
           // {
           //     con.Open();
           //     //
           //}