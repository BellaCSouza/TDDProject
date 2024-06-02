using System;
using TDDProject;

namespace TestTDDProject
{
    public class UnitTest1
    {
        public Calculator buildClass()
        {
            string date = DateTime.Now.ToString();
            Calculator calc = new Calculator(DateTime.Now.ToString());
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestADD(int x, int y, int result)
        {
            Calculator calc = buildClass();

            int resultCalc = calc.add(x, y);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiply(int x, int y, int result)
        {
            Calculator calc = buildClass();

            int resultCalc = calc.multiply(x, y);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TestDivide(int x, int y, int result)
        {
            Calculator calc = buildClass();

            int resultCalc = calc.divide(x, y);

            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void TestSubtract(int x, int y, int result)
        {
            Calculator calc = buildClass();

            int resultCalc = calc.subtract(x, y);

            Assert.Equal(result, resultCalc);
        }

        [Fact]
        public void TestDivideByZero()
        {
            Calculator calc = buildClass();
            Assert.Throws<DivideByZeroException>(
                () => calc.divide(3,0));
        }

        [Fact]
        public void TestHistory()
        {
            Calculator calc = buildClass();

            calc.add(1, 2);
            calc.add(3, 2);
            calc.add(8, 4);
            calc.add(5, 3);

            var list = calc.history();

            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}