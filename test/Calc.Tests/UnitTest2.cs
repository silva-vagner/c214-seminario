using Calculadora;
using Moq;

namespace Tests
{
    [Collection("Sequential")]
    public class UnitTest1
    {
        [Fact]
        public void MaquinaCalc_DadoSomaDeDoisNumerosDouble_RetornaStringSomaEResultadoDouble()
        {
            // Arrange
            Moq.Mock<ICalc> mock = new Moq.Mock<ICalc>();
            mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("somar", 7));

            MaquinaCalc maqCalc = new MaquinaCalc(mock.Object);

            // Act
            (string operacao, double resultado) op = maqCalc.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>());

            // Assert
            Assert.IsType<string>(op.operacao);
            Assert.IsType<double>(op.resultado);
        }
        [Fact]
        public void Subtrair_Dois_Numeros()
        {
            // Arrange
            Moq.Mock<ICalc> mock = new Moq.Mock<ICalc>();
            mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("subtrair", -1.3));

            MaquinaCalc maqCalc = new MaquinaCalc(mock.Object);

            // Act
            (string operacao, double resultado) op = maqCalc.Calcular("subtrair", 3.2, 4.5);

            // Assert
            Assert.Equal("subtrair", op.operacao);
            Assert.Equal(-1.3, op.resultado);
        }
        [Fact]
        public void Multiplicar_Dois_Numeros()
        {
            // Arrange
            Moq.Mock<ICalc> mock = new Moq.Mock<ICalc>();
            mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("multiplicar", 14.4));

            MaquinaCalc maqCalc = new MaquinaCalc(mock.Object);

            // Act
            (string operacao, double resultado) op = maqCalc.Calcular("multiplicar", 3.2, 4.5);

            // Assert
            Assert.Equal("multiplicar", op.operacao);
            Assert.Equal(14.4, op.resultado);
        }
        [Fact]
        public void Dividir_Dois_Numeros()
        {
            // Arrange
            Moq.Mock<ICalc> mock = new Moq.Mock<ICalc>();
            mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("dividir", 0.71));

            MaquinaCalc maqCalc = new MaquinaCalc(mock.Object);

            // Act
            (string operacao, double resultado) op = maqCalc.Calcular("multiplicar", 3.2, 4.5); 

            // Assert
            Assert.Equal("dividir", op.operacao);
            Assert.Equal(0.71, op.resultado);
        }

    }
}
