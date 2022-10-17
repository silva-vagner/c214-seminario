using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            (string op, double res) resultado = calc.Calcular("soma", -5, -2);
            Console.WriteLine($"Operacao: {resultado.op} \nResultado: {resultado.res}" );
        }
    }
}
