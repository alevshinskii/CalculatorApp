using CalculatorLibrary;

namespace CalculatorLibrary.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldDoAddition()
        {
            Calculator calculator = new Calculator();
            var num1 = 1;
            var num2 = 2;
            var op = "a";
            var result = calculator.DoOperation(num1, num2, op);
            calculator.Finish();
            Assert.Equal(3,result);

        }

        [Fact]
        public void ShouldDoSubtract()
        {
            Calculator calculator = new Calculator();
            var num1 = 1;
            var num2 = 2;
            var op = "s";
            var result = calculator.DoOperation(num1, num2, op);
            calculator.Finish();
            Assert.Equal(-1,result);

        }

        [Fact]
        public void ShouldDoMultiply()
        {
            Calculator calculator = new Calculator();

            var num1 = 1;
            var num2 = 2;
            var op = "m";
            var result = calculator.DoOperation(num1, num2, op);
            calculator.Finish();
            Assert.Equal(2,result);

        }
        
        [Fact]
        public void ShouldDoDivide()
        {
            Calculator calculator = new Calculator();

            var num1 = 1;
            var num2 = 2;
            var op = "d";
            var result = calculator.DoOperation(num1, num2, op);
            calculator.Finish();
            Assert.Equal(0.5,result);

        }

        [Fact]
        public void ShouldDoNothingWhenOperationLetterUnknown()
        {
            Calculator calculator = new Calculator();

            var num1 = 1;
            var num2 = 2;
            var op = "f";
            
            var result = calculator.DoOperation(num1, num2, op);

            calculator.Finish();
            Assert.Equal(double.NaN,result);

        }
    }
}