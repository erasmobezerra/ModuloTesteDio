using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesDeStringsTest
    {
        private ValidacoesDeStrings _validacao;

        public ValidacoesDeStringsTest()
        {
            _validacao = new ValidacoesDeStrings();
        }

        [Fact] // Indica que é um método de teste
        public void RetornarQuantidadeDe5CaracteresDaStringTeste()
        {
            // Arrange - preparar o cenário
            string texto = "teste";

            // Act - executar o cenário
            int quantidadeCaractere = _validacao.ContarCaracteres(texto);

            // Assert - verificar se o retorno foi o esperado
            Assert.Equal(5, quantidadeCaractere);
        }

    }
}