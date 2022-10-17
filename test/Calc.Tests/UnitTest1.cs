using Calculadora;

namespace Tests
{
    [Collection("Sequential")]
    public class UnitTest2 : IClassFixture<CalcFixture>
    {
        private readonly CalcFixture _calcFixture;
        
        public UnitTest2(CalcFixture calcFixture){
            _calcFixture = calcFixture;
        }

        [Fact]
        public void Calcular_SomaDoisDouble_RetornaDouble()
        {
            var calc = new Calc();

            var result = calc.Calcular("soma", 1, 2);

            Assert.Equal(3, result.resultado);
            Assert.IsType<double>(result.resultado);
        }

        [Fact]
        public void Calcular_CalculaDivisao_RetornoComPrecisao2()
        {
            var calc = new Calc();

            var result = calc.Calcular("divisao", 5, 6);

            Assert.Equal(0.83, result.resultado, 2);
        }

        [Fact]
        [Trait("Category", "Exceptions")]
        public void Calcular_CalculaDivisaoPorZero_LancaExcecao()
        {
            var calc = _calcFixture.calc;

            var exceptionDetails = Assert.Throws<ArgumentException>(() => calc.Calcular("divisao", 2, 0));
            Assert.Equal("Divisao por zero", exceptionDetails.Message);
        }

        [Fact]
        [Trait("Category", "Exceptions")]
        public void Calcular_DadoStringInvalida_LancaExcecao()
        {
            var calc = _calcFixture.calc;

            var exceptionDetails = Assert.Throws<ArgumentException>(() => calc.Calcular("exponenciacao", 2, 2));
            Assert.Equal("Operacao Invalida", exceptionDetails.Message);
        }

        [Fact]
        public void Calcular_DadoStringValida_IgnoraStringCase()
        {
            var calc = _calcFixture.calc;

            var result = calc.Calcular("MULTIPLICACAO", 2, 3);
            
            Assert.Equal("multiplicacao", result.operacao);
        }

        [Fact]
        public void Calcular_DadoStringValida_IgnoraStringCase2()
        {
            var calc = _calcFixture.calc;

            var result = calc.Calcular("suBTRACAO", 4, 2);
            
            Assert.Equal("subtracao", result.operacao);
        }

        [Theory]
        [InlineData("mulTIPLICACAO", 1, 3)]
        [InlineData("suBTRACAO", 3, 2)]
        public void Calcular_DadoStringValida_IgnoraStringCase3(String operacao, double a, double b)
        {
            var calc = _calcFixture.calc;

            var result = calc.Calcular(operacao, a, b);
            
            Assert.Equal(operacao.ToLower(), result.operacao);
        }
       
        
    }
}
