using LabTask2;
using NUnit.Framework;
namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1_Addition_Two_Plus_Two_EqualsTo_Four()
        {
            Calculator.num1 = 2.00d;//arrange
            Calculator.num2 = 2.00d;//arrange
            Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(4.00d, Calculator.result); //assert
        }

        [Test]
        public void Test2_Addition_Three_Plus_Three_EqualsTo_Six()
        {
            Calculator.num1 = 3.00d;//arrange
            Calculator.num2 = 3.00d;//arrange
            Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(6.00d, Calculator.result); //assert2
        }

        [Test]
        public void Test3_Addition_FourDecimalFiveZero_Plus_FourDecimalFiveZero_EqualsTo_Nine()
        {
            Calculator.num1 = 4.50d;//arrange
            Calculator.num2 = 4.50d;//arrange
            Calculator.Addition(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(9.00d, Calculator.result); //assert2
        }

        

    }
}
