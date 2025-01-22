using EvaluationTests;

namespace TestEvaluation.UnitTests;
[TestClass]
public class MathOperationsTests
{
    [TestMethod]
    [DataRow(2, 2, 4)]
    public void Add_WithNumberOneAndNumberTwo_ReturnsExpectedResult(int numberOne, int numberTwo, int expectedResult)
    {
        var mathOperations = new MathOperations();
        var result = mathOperations.Add(numberOne, numberTwo);
        Assert.AreEqual(expectedResult, result);
        
    }

    [TestMethod]
    [DataRow(3, 1, 3)]
    public void Divide_WithNumberOne_ReturnsExpectedResult(int numberOne, int numberTwo, int expectedResult)
    {
        var mathOperations = new MathOperations();
        var result = mathOperations.Divide(numberOne, numberTwo);
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void Divide_IfNumberTwoZero_ReturnException()
    {
        var mathOperations = new MathOperations();
        Assert.ThrowsException<ArgumentException>(()=> mathOperations.Divide(1, 0));
    }
}