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

        [Test]
        public void Test1_Subtraction_Eight_Minus_Three_EqualsTo_Five()
        {
            Calculator.num1 = 8.00d;//arrange
            Calculator.num2 = 3.00d;//arrange
            Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(5.0d, Calculator.result); //assert
        }

        [Test]
        public void Test2_Subtraction_NineDecimalFiveZero_Minus_FourDecimalFiveZero_EqualsTo_Five()
        {
            Calculator.num1 = 9.50d;//arrange
            Calculator.num2 = 4.50d;//arrange
            Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(5.00d, Calculator.result); //assert
        }

        [Test]
        public void Test3_Subtraction_Ten_Minus_Eight_EqualsTo_Two()
        {
            Calculator.num1 = 10.00d;//arrange
            Calculator.num2 = 8.00d;//arrange
            Calculator.Subtraction(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(2.00d, Calculator.result); //assert
        }

        [Test]
        public void Test1_Multiplication_Two_Multiply_By_TwoDecimalFiveZero_EqualsTo_Five()
        {
            Calculator.num1 = 2.00d;//arrange
            Calculator.num2 = 2.50d;//arrange
            Calculator.Multiplication(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(5d, Calculator.result); //assert
        }

        [Test]
        public void Test2_Multiplication_Five_Multiply_By_Five_EqualsTo_TwentyFive()
        {
            Calculator.num1 = 5.00d;//arrange
            Calculator.num2 = 5.00d;//arrange
            Calculator.Multiplication(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(25d, Calculator.result); //assert
        }

        [Test]
        public void Test3_Multiplication_Six_Multiply_By_Six_EqualsTo_ThirtySix()
        {
            Calculator.num1 = 6.000d;//arrange
            Calculator.num2 = 6.0000d;//arrange
            Calculator.Multiplication(Calculator.num1, Calculator.num2); //act
            Assert.AreEqual(36.00d, Calculator.result); //assert
        }



    }
}
