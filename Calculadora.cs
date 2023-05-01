using System;
namespace Calculadora
{
    public class Calcular
    {
        public void somar(int num1, int num2 )
        
        {
            Console.WriteLine($"O Resultado da soma é:{num1} + {num2} = {num1 + num2}");   
        }        
        public void subtrair (int num1, int num2)
        {
            Console.WriteLine($"O Resultado da subtração é: {num1} - {num2} = {num1 - num2}");
        }
        public void dividir (int num1, int num2)
        {
            Console.WriteLine($"O Resultado da divisão é: {num1} / {num2} = {num1 / num2}");
        }
        public void multiplicar (int num1, int num2)
        {
            Console.WriteLine($"O Resultado da multiplicação é: {num1} * {num2} = {num1 * num2}");
        }       
    }
}