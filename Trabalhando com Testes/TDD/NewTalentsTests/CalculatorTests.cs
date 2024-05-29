using NewTalents;

namespace NewTalentsTests;

public class CalculatorTests
{
    public Calculator BuildClass()
    {
        string date = "29/05/2024";
        Calculator calc = new Calculator("29/05/2024");

        return calc;
    }

    // No InlineData está sendo informado valor1, valor2 e o resultado esperado.
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void SumTest(int valueOne, int valueTwo, int result)
    {
        // Arrange
        Calculator calc = BuildClass();
        // Act
        int resultCalculator = calc.Sum(valueOne, valueTwo);

        // Assert - primeiro parâmetro é o valor esperado, depois o que está na variável.
        Assert.Equal(result, resultCalculator);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 3, 2)]
    public void SubtractionTest(int valueOne, int valueTwo, int result)
    {
        // Arrange
        Calculator calc = BuildClass();

        // Act
        int resultCalculator = calc.Subtraction(valueOne, valueTwo);

        // Assert - primeiro parâmetro é o valor esperado, depois o que está na variável.
        Assert.Equal(result, resultCalculator);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void MultiplicationTest(int valueOne, int valueTwo, int result)
    {
        // Arrange
        Calculator calc = BuildClass();

        // Act
        int resultCalculator = calc.Multiplication(valueOne, valueTwo);

        // Assert - primeiro parâmetro é o valor esperado, depois o que está na variável.
        Assert.Equal(result, resultCalculator);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(8, 2, 4)]
    public void DivisionTest(int valueOne, int valueTwo, int result)
    {
        // Arrange
        Calculator calc = BuildClass();

        // Act
        int resultCalculator = calc.Division(valueOne, valueTwo);

        // Assert - primeiro parâmetro é o valor esperado, depois o que está na variável.
        Assert.Equal(result, resultCalculator);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        Calculator calc = BuildClass();

        // Tratando Exceptions no xUnit. 
        Assert.Throws<DivideByZeroException>(
            () => calc.Division(3, 0)
        );
    }

    [Fact]
    public void TestHistorical()
    {
        Calculator calc = BuildClass();

        calc.Sum(1, 2);
        calc.Sum(2, 8);
        calc.Sum(4, 7);
        calc.Sum(10, 14);

        var list = calc.HistoricalCalculations();

        // NotEmpty vai verificar se a lista está vazia.
        Assert.NotEmpty(calc.HistoricalCalculations());
        // Verificando se tem 3 cálculos no histórico da calculadora.
        Assert.Equal(3, list.Count);
    }
}