using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppXamarin;

namespace TesteAppXamarin
{  
    [TestClass]
    public class TesteAppXamarin
    {
        [TestMethod]
        public void Teste_Soma()
        {
            int resultado = AppXamarin.Program.soma(4, 4);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Teste_CalculoICMS_NF01()
        {
            decimal resultado = AppXamarin.Program.calculoICMS_NF01(10000);
            Assert.AreEqual(1800, resultado);
        }

        [TestMethod]
        public void Teste_CalculoICMS_NF02()
        {
            decimal resultado = AppXamarin.Program.calculoICMS_NF02(10000);
            Assert.AreEqual(1200, resultado);
        }
    }
}
