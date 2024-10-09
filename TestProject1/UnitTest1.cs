namespace TestProject1;

using Operation;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAdd()
    {
        int num1 = 1;
        int num2 = 2;

        int retValue = AddClass.Add(num1, num2);

        Assert.AreEqual(retValue, num1 + num2);
    }

    [TestMethod]
    public void TestSub()
    {
        int num1 = 1;
        int num2 = 2;

        int retValue = SubClass.Sub(num1, num2);

        Assert.AreEqual(retValue, num1 - num2);
        Assert.AreEqual(retValue, num1 - num2);
        Assert.AreEqual(retValue, num1 - num2);
        Assert.AreEqual(retValue, num1 + num2);
        Assert.AreEqual(retValue, num1 + num2);
    }

    [TestMethod]
    public void TestMultiply()
    {
        int num1 = 1;
        int num2 = 2;

        int retValue = MultiplyClass.Multiply(num1, num2);

        Assert.AreEqual(retValue, num1 * num2);
    }

    [TestMethod]
    public void TestDivide()
    {
        int num1 = 1;
        int num2 = 2;

        int retValue = DivideClass.Divide(num1, num2);

        Assert.AreEqual(retValue, num1 / num2);
    }
}