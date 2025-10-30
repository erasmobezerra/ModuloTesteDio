using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraImpTests
{

    private CalculadoraImp _calc;

    public CalculadoraImpTests()
    {
        _calc = new CalculadoraImp();
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
