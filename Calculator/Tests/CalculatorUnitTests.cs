using Calculator;
using System;
using Xunit;

namespace Tests
{
    public class CalculatorUnitTests
    {
        private readonly CalculatorApp calculator = new();

        [Fact]
        public void Calculator_Sum()
        {
            var result = this.calculator.Sum(5, 7);

            Assert.Equal(12, result);
        }

        [Fact]
        public void Calculator_Substract()
        {
            var result = this.calculator.Substract(5, 7);

            Assert.Equal(-2, result);
        }

        [Fact]
        public void Calculator_Multiply()
        {
            var result = this.calculator.Multiply(5, 7);

            Assert.Equal(35, result);
        }

        [Fact]
        public void Calculator_Divide()
        {
            var result = this.calculator.Divide(2, 5);

            Assert.Equal(0.4, result);
        }

        [Fact]
        public void Calculator_DivideZero() => Assert.Throws<InvalidOperationException>(() => this.calculator.Divide(2, 0));
    }
}