using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppXamarin
{
    public class Program
    {       
        static void Main(string[] args)
        {
            Console.Write(calculoICMS_NF01(10000));
            Console.ReadKey();
        }

        public static int soma(int n1, int n2)
        {
            return (n1 + n2);
        }

        public static decimal calculoICMS_NF01(decimal ValorMercadoria)
        {
            return (ValorMercadoria * (19m / 100m));
        }

        public static decimal calculoICMS_NF02(decimal ValorMercadoria)
        {
            return (ValorMercadoria * (12m / 100m));
        }
    }    
}
