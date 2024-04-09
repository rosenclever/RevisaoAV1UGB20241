namespace RevisaoAV1Tests
{
    [TestClass]
    public class MatematicaTests
    {
        [TestMethod]
        public void FatorialTest()
        {
            int num1 = 5;
            Fatorial fat = new Fatorial();
            int fatCalculado = fat.CalculoFatorial(num1);
            Assert.AreEqual(120, fatCalculado);
        }
        [TestMethod]
        public void FibonacciTest()
        {
            int posicao = 6;
            Fibonacci fibo = new Fibonacci();
            int valorPosicaoFibo = fibo.CalculoFibonacci(posicao);
            Assert.AreEqual(8, valorPosicaoFibo);
        }

        [TestMethod]
        public void BaskaraTest()
        {
            int num1 = 1;
            int num2 = -3;
            int num3 = -54;
            int[] raizesEsperadas = {-6, 9 };
            int[] raizesOrdenadas = Baskara.CalculoRaiz1(num1, num2, num3);
            Assert.AreEqual(raizesEsperadas, raizesOrdenadas);
        }
    }
}