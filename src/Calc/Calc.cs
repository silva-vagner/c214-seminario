using System;

namespace Calculadora
{
    public class Calc : ICalc
    {
        public (string operacao, double resultado) Calcular(string operacao, double a, double b)
        {
            (string operacao, double resultado) resultadoOperacao;
            operacao = operacao.ToLower();
            
            double c;
            switch (operacao)
            {
                case "soma":
                    c = a + b;
                    break;
                case "subtracao":
                    c = a - b;
                    break;
                case "multiplicacao":
                    c = a * b;
                    break;
                case "divisao":
                    if(b == 0) 
                    {
                        throw new ArgumentException("Divisao por zero");
                    }
                    c = Math.Round(a / b,2);
                    break;
                default:
                    throw new ArgumentException("Operacao Invalida");
            }
            resultadoOperacao = (operacao, c);
            return resultadoOperacao;
        }
    }
}
