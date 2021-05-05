using NUnit.Framework;
using TestExplorerExample;

namespace ImportantTests.Math
{
    public class CalculatorTests
    {
       

        [Test]
        public void Addtion()
        {
            var calc = new Calculator();
            Assert.AreEqual(5, calc.Addtion(5, 5));
        }

        [Test]
        public void Substracion()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Substraction(5, 5));
        }

        [Test]
        public void Multiplication()
        {
            var calc = new Calculator();
            Assert.AreEqual(25, calc.Multiplication(5, 5));
        }

        [Test]
        public void Division()
        {
            var calc = new Calculator();
            Assert.AreEqual(1, calc.Division(5, 5));
        }


        [Test]
        public void AddtionAndMultiplication()
        {
            var calc = new Calculator();
            var firstAddtion = calc.Addtion(5, 5);
            Assert.AreEqual(calc.Addtion(firstAddtion, 5), calc.Multiplication(3, 5));
        }

    }
}