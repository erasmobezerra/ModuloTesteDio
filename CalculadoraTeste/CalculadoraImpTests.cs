using Calculadora.Services;

namespace CalculadoraTeste
{
    public class CalculadoraImpTests
    {

        // Instância da classe CalculadoraImp que será testada
        private CalculadoraImp _calc;

        // Construtor da classe de teste
        public CalculadoraImpTests()
        {
            _calc = new CalculadoraImp(); // Inicializa a instância da classe CalculadoraImp antes de cada teste
        }

        // Teste de soma
        [Fact] // Indica que é um método de teste
        public void DeveSomar5Com10ERetornar15()
        {
            // Arrange - preparar o cenário
            int num1 = 5;
            int num2 = 10;

            // Act - executar o cenário
            int resultado = _calc.Somar(num1, num2);

            // Assert - verificar se o retorno foi o esperado
            Assert.Equal(15, resultado);

        }

        // Teste de subtração
        [Fact]
        public void DeveSubtrair10De5ERetornarNegativo5()
        {
            // Arrange - preparar o cenário
            int num1 = 5;
            int num2 = 10;

            // Act - executar o cenário
            int resultado = _calc.Subtrair(num1, num2);

            // Assert - verificar se o retorno foi o esperado
            Assert.Equal(-5, resultado);
        }

        // Teste de multiplicação
        [Fact]
        public void DeveMultiplicar5Por10ERetornar50()
        {
            // Arrange - preparar o cenário
            int num1 = 5;
            int num2 = 10;

            // Act - executar o cenário
            int resultado = _calc.Multiplicar(num1, num2);

            // Assert - verificar se o retorno foi o esperado
            Assert.Equal(50, resultado);
        }

        // Teste de divisão
        [Fact]
        public void DeveDividir5Por10ERetornar0_5()
        {
            // Arrange - preparar o cenário
            int num1 = 5;
            int num2 = 10;

            // Act - executar o cenário
            double resultado = _calc.Dividir(num1, num2);

            // Assert - verificar se o retorno foi o esperado
            Assert.Equal(0.5, resultado);
        }

        // Teste de divisão por zero
        [Fact]
        public void DeveLancarExcecaoAoDividirPorZero()
        {
            // Arrange - preparar o cenário
            int num1 = 5;
            int num2 = 0;

            // Act e Assert - verificar se a exceção foi lançada
            var exception = Assert.Throws<ArgumentException>(() => _calc.Dividir(num1, num2));
            Assert.Equal("O divisor não pode ser zero.", exception.Message);
        }

        [Fact] // Indica que é um método de teste
        public void DeveRetornarTruePois10EhNumeroPar()
        {
            // Arrange - preparar o cenário
            int num = 10;

            // Act - executar o cenário
            bool ehPar = _calc.EhPar(num);

            // Assert - verificar se o retorno foi o esperado
            Assert.True(ehPar);
        }

        [Theory] // Indica que é um método de teste com múltiplos dados de entrada
        [InlineData(new int[] { 2, 4 })]
        [InlineData(new int[] { 6, 8, 10 })]
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
        {
            // Act e Assert
            Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        }

    }

}

