using StringCalculatorTDD;
using System.Runtime.CompilerServices;

namespace StringCalculatorTDDTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        private StringCalculator _sut;

        public StringCalculatorTests()
        {
            _sut = new StringCalculator();
        }

        [TestMethod]
        public void Add_Empty_String_Returns_0()
        {
            // ARRANGE
            string input = "";
            int expected = 0;

            // ACT
            var result = _sut.Add(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_Only_One_Number_Returns_Number()
        {
            // ARRANGE
            string input = "2";
            int expected = 2;

            // ACT
            var result = _sut.Add(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_Several_Numbers_Returns_Sum()
        {
            // ARRANGE
            string input = "2,3,4";
            int expected = 9;

            // ACT
            var result = _sut.Add(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_Ignore_Certain_Numbers_Returns_Sum()
        {
            // ARRANGE
            string input = "-1,999,1000,1001";
            int expected = 1999;

            // ACT
            var result = _sut.Add(input);

            // ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}