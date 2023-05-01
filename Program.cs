using System;
using Calculadora;

Calcular calculadora = new Calcular();

Console.WriteLine("Digite o numero referente a operação que deseja realizar:");
Console.WriteLine(" 1 - Adição");
Console.WriteLine(" 2 - Substração");
Console.WriteLine(" 3 - Divisão");
Console.WriteLine(" 4 - Multiplicação");
int operacao = Convert.ToInt32(Console.ReadLine());

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
