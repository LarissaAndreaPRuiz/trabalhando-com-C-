using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringBuilder();
            for (int x = 0; x < 100; x++)
            {
                str.Append(x.ToString() + "");  
            }
            Console.WriteLine(str.ToString());
        }
    }
}
