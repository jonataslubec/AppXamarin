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
            int resultado = ProjetoCalculadora.Calculadora.soma(4, 4);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Teste_CalculoICMS_NF01()
        {
            decimal resultado = ProjetoCalculadora.Calculadora.calculoICMS_NF01(10000);
            Assert.AreEqual(1800, resultado);
        }

        [TestMethod]
        public void Teste_CalculoICMS_NF02()
        {
            decimal resultado = ProjetoCalculadora.Calculadora.calculoICMS_NF02(10000);
            Assert.AreEqual(1200, resultado);
        }
    }
}
