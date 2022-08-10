using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldDoAddition()
        {
            var num1 = 1;
            var num2 = 2;
            var op = "a";
            var result = Calculator.DoOperation(num1, num2, op);
            Assert.Equal(3,result);

        }

        [Fact]
        public void ShouldDoSubtract()
        {
            var num1 = 1;
            var num2 = 2;
            var op = "s";
            var result = Calculator.DoOperation(num1, num2, op);
            Assert.Equal(-1,result);

        }

        [Fact]
        public void ShouldDoMultiply()
        {
            var num1 = 1;
            var num2 = 2;
            var op = "m";
            var result = Calculator.DoOperation(num1, num2, op);
            Assert.Equal(2,result);

        }
        
        [Fact]
        public void ShouldDoDivide()
        {
            var num1 = 1;
            var num2 = 2;
            var op = "d";
            var result = Calculator.DoOperation(num1, num2, op);
            Assert.Equal(0.5,result);

        }

        [Fact]
        public void ShouldDoNothingWhenOperationLetterUnknown()
        {
            var num1 = 1;
            var num2 = 2;
            var op = "f";
            var result = Calculator.DoOperation(num1, num2, op);
            Assert.Equal(double.NaN,result);

        }
    }
}