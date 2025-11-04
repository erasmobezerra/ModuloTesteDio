Claro, Erasmo! Aqui está um resumo direto e prático sobre **Testes Unitários** com exemplo usando **xUnit**, ideal para quem está começando com .NET:

---

## 🧪 O que são Testes Unitários?

**Definição**:  
Testes unitários são métodos automatizados que verificam se **uma unidade de código** (geralmente uma função ou método) está funcionando corretamente.

---

## 🎯 Por que são importantes?

- **Detectam erros cedo** no desenvolvimento
- **Facilitam manutenção** e refatoração segura
- **Documentam o comportamento esperado** do código
- **Aumentam a confiança** na qualidade do software

---

## ⚙️ Exemplo simples com xUnit

Suponha que temos uma classe `Calculadora` com um método `Somar`:

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
}
```

Agora, criamos um teste com xUnit:

```csharp
using Xunit;

public class CalculadoraTests
{
    [Fact] // Indica que é um teste unitário
    public void Somar_DeveRetornar15_QuandoSomar5Com10()
    {
        // Arrange
        var calc = new Calculadora();
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }
}
```

---

## 🧰 Como executar os testes

- No Visual Studio: clique com o botão direito na pasta de testes → **Run Tests**
- Na linha de comando:  
  ```bash
  dotnet test
  ```

---

Se quiser, posso te ajudar a configurar um projeto de testes do zero ou incluir testes para outros métodos como subtração, multiplicação ou verificação de número par. Só dizer!
