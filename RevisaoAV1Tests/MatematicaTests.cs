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
    }
}