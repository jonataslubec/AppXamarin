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
            calcularICMS(1000);
        }


        public static decimal calcularICMS(decimal ValorMercadoria)
        {
            return (ValorMercadoria * (18m / 100m));
        }
    }
}
