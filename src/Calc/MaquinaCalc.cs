namespace Calculadora
{
    public class MaquinaCalc
    {
        private ICalc calc;

        public MaquinaCalc() : this(new Calc())
        {}

        public MaquinaCalc(ICalc obj)
        {
            this.calc = obj;
        }

        public (string operacao, double resultado) Calcular(string tipoOperacao, double a, double b)
        {
            return calc.Calcular(tipoOperacao, a, b);
        }
    }
}
