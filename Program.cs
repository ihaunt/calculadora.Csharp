using System;
using Calculadora;


Calcular calculadora = new Calcular();

Console.WriteLine("Digite o número referente à operação que deseja realizar:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Multiplicação");
int operacao = 0;

bool operacaoValida = false;
while (!operacaoValida)
{
Console.WriteLine("Digite um número válido: 1, 2, 3 ou 4");
bool inputValido = int.TryParse(Console.ReadLine(), out operacao);
operacaoValida = inputValido && (operacao >= 1 && operacao <= 4);
}

Console.WriteLine("Digite o primeiro número:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int num2 = Convert.ToInt32(Console.ReadLine());


if (operacao == 1)
{
    calculadora.somar(num1, num2);
}  
else if (operacao == 2)
{
    calculadora.subtrair(num1, num2);
}         
else if (operacao == 3)
{
    calculadora.dividir(num1, num2);
}
else if (operacao == 4)
{
    calculadora.multiplicar(num1, num2);
}
else 
{
  Console.WriteLine("Operação inválida.");
}
