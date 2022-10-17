namespace Calculadora
{
    public interface ICalc
    {
        (string operacao, double resultado) Calcular(string operacao, double a, double b);
    }
}
