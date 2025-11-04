# Projeto Calculadora com Testes Unitários

Este é um projeto de demonstração desenvolvido como parte do curso de formação .NET Developer da DIO (Digital Innovation One). O projeto consiste em uma calculadora simples com funcionalidades básicas e implementação de testes unitários.

## 📋 Funcionalidades

O projeto possui as seguintes funcionalidades:

- **Calculadora**:
  - Soma de dois números inteiros
  - Verificação se um número é par
- **Validações de Strings**:
  - Contagem de caracteres em uma string

## 🛠️ Tecnologias Utilizadas

- .NET 9.0
- C#
- xUnit (Framework de Testes)

## 📦 Pré-requisitos

Para executar este projeto, você precisa ter instalado:

- [.NET SDK 9.0](https://dotnet.microsoft.com/download)
- Visual Studio 2022 ou Visual Studio Code

## 🚀 Como executar o projeto

### Clonando o repositório

```bash
git clone https://github.com/erasmobezerra/ModuloTesteDio.git
cd ModuloTesteDio
```

### Restaurando as dependências

```bash
dotnet restore
```

### Compilando o projeto

```bash
dotnet build
```

### Executando os testes

```bash
dotnet test
```

### Executando a aplicação

```bash
cd Calculadora
dotnet run
```

## 📂 Estrutura do Projeto

- `Calculadora/`: Projeto principal contendo a implementação das funcionalidades
  - `Services/`: Contém as classes de implementação
    - `CalculadoraImp.cs`: Implementação das operações matemáticas
    - `ValidacoesDeStrings.cs`: Implementação das validações de strings

- `CalculadoraTeste/`: Projeto de testes
  - `CalculadoraImpTests.cs`: Testes unitários para as operações matemáticas
  - `ValidacoesDeStringsTest.cs`: Testes unitários para as validações de strings

## ✅ Executando os Testes

O projeto inclui testes unitários que podem ser executados usando o comando:

```bash
dotnet test
```

Os testes verificam:

- Operações matemáticas básicas
- Validações de strings


## 🤝 Como contribuir

1. Crie uma branch com nome descritivo: `feature/minha-mudanca`.  
2. Faça commits pequenos e claros.  
3. Abra Pull Request descrevendo o que foi alterado e por quê.  

---

🙏 Agradeço profundamente à **Digital Innovation One** por proporcionar este aprendizado gratuito e de qualidade. Um reconhecimento especial ao professor **[Leonardo Buta](https://www.linkedin.com/in/leonardo-buta/)** pela excelente didática e orientação durante todo o processo.

<div align="center">
  <p>⭐ Se este projeto foi útil para você, considere dar uma estrela!</p>
</div>
