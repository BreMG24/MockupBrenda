using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumaNumeros.Tests
{
    [TestClass]
    public class ProgramTests2
    {
        [TestMethod]
        public void TestSuma()
        {
            int numero1 = -2;
            int numero2 = 3;
            int resultadoEsperado = 1;

            int resultado = numero1 + numero2;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
