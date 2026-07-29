
using Calculadora.Services;

CalculadoraImp calculadora = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {calculadora.Somar(num1, num2)}");

Console.WriteLine($"{num1} - {num2} = {calculadora.Subtrair(num1, num2)}");

Console.WriteLine($"{num1} * {num2} = {calculadora.Multiplicar(num1, num2)}");

try
{
    Console.WriteLine($"{num1} / {num2} = {calculadora.Dividir(num1, num2)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine($"O número {num1} é par? {calculadora.EhPar(num1)}");

Console.WriteLine($"O número {num2} é par? {calculadora.EhPar(num2)}");