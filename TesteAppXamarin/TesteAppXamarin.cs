using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppXamarin;

namespace TesteAppXamarin
{
    [TestClass]
    public class TesteLifeCycle
    {
        [TestMethod]
        public void Teste_CalculoICMS()
        {
            decimal resultado = Program.calcularICMS(500);
            Assert.AreEqual(90, resultado);
        }
    }
}
